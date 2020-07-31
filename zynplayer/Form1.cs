using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NAudio.Wave;
using DiscordRPC;

namespace zynplayer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            InitializeRPC();
            UpdateRPC();
        }

        bool closing;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            closing = true;
        }

        private void timer_Tick(object sender, EventArgs e) {
            UpdateRPC();
        }

        private string FormattedTime(int s) {
            TimeSpan time = TimeSpan.FromSeconds(s);

            return time.ToString(@"mm\:ss");
        }

        #region Moveable Window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void drag(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        #endregion

        #region UI Element Design
        private void BtnMouseHover(object sender, EventArgs e) {
            Button btn = sender as Button;
            btn.ForeColor = Color.FromArgb(218, 212, 187);
        }

        private void BtnMouseLeave(object sender, EventArgs e) {
            Button btn = sender as Button;
            btn.ForeColor = Color.FromArgb(78, 75, 66);
        }

        private void ImageBtnMouseHover(object sender, EventArgs e) {
            Button btn = sender as Button;
            btn.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(btn.Tag.ToString() + "Hover");
        }

        private void ImageBtnMouseLeave(object sender, EventArgs e) {
            Button btn = sender as Button;
            btn.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(btn.Tag.ToString());
        }



        private void DrawItem(object sender, DrawItemEventArgs e) {
            e.DrawBackground();

            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < songList.Items.Count) {
                Graphics g = e.Graphics;

                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.FromArgb(78, 75, 66) : Color.FromArgb(218, 212, 187));
                g.FillRectangle(backgroundColorBrush, e.Bounds);

                string itemText = songList.Items[itemIndex].ToString();

                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.FromArgb(218, 212, 187)) : new SolidBrush(Color.FromArgb(78, 75, 66));
                g.DrawString(itemText, new Font("SCE-PS3 Rodin LATIN", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))), itemTextColorBrush, songList.GetItemRectangle(itemIndex).Location);

                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }

            e.DrawFocusRectangle();
        }
        #endregion

        #region UI Element Function
        private void closeBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void minBtn_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        List<string> songPaths = new List<string>();

        private void addBtn_Click(object sender, EventArgs e) {
            ofd.ShowDialog();
            songPaths.Add(ofd.FileName);
            songList.Items.Add(ofd.SafeFileName);
        }

        private void removeBtn_Click(object sender, EventArgs e) {
            songPaths.RemoveAt(songList.SelectedIndex);
            songList.Items.RemoveAt(songList.SelectedIndex);
        }

        WaveOutEvent wo = new WaveOutEvent();
        AudioFileReader af;


        bool isPlaying = false;
        string songPlaying;

        private void playBtn_Click(object sender, EventArgs e) {
            isPlaying = !isPlaying;
            songPlaying = songList.SelectedItem.ToString();

            if (songList.SelectedIndex < 0) songList.SelectedIndex = 0;
            af = new AudioFileReader(songPaths[songList.SelectedIndex]);
            af.Volume = 1 - volumebarSlider.Location.Y / 44f;

            wo.PlaybackStopped += (s, a) => { if (closing) { wo.Dispose(); af.Dispose(); } };

            switch (isPlaying) {
                case false:
                    timer.Stop();
                    wo.Stop();
                    playBtn.Tag = "playBtn";
                    playBtn.BackgroundImage = Properties.Resources.playBtnHover;
                    break;
                case true:
                    wo.Init(af);
                    wo.Play();
                    timer.Start();

                    playBtn.Tag = "pauseBtn";
                    playBtn.BackgroundImage = Properties.Resources.pauseBtnHover;
                    break;
            }
        }

        private void volumeMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                if (!(e.Y + volumebarSlider.Top < 0)) {
                    if (!(e.Y + volumebarSlider.Top > 44)) {
                        volumebarSlider.Location = new Point(0, e.Y + volumebarSlider.Top);

                        af.Volume = 1 - volumebarSlider.Location.Y / 44f;
                    }
                }
            }
        }


        #endregion

        #region Discord RPC
        public DiscordRpcClient rpcClient;

        private void InitializeRPC() {
            rpcClient = new DiscordRpcClient("715943346664636467");
            rpcClient.Initialize();

            
        }

        private void UpdateRPC() {
            try {
                rpcClient.SetPresence(new RichPresence() {
                    Details = songPlaying,
                    State = FormattedTime((int)af.CurrentTime.TotalSeconds),
                    Assets = new Assets() {
                        LargeImageKey = "icon",
                        LargeImageText = songPlaying,
                        SmallImageKey = "icon"
                    }
                });
            } catch (Exception ex) { }
        }

        #endregion
    }
}
