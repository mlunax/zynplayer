namespace zynplayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleBar = new System.Windows.Forms.Panel();
            this.minBtn_light = new System.Windows.Forms.Button();
            this.closeBtn_light = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.bottombarShadow = new System.Windows.Forms.Panel();
            this.bottomBar = new System.Windows.Forms.Panel();
            this.volumeBar = new System.Windows.Forms.Panel();
            this.volumebarSlider = new System.Windows.Forms.Panel();
            this.playBtn = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.Panel();
            this.trackbarSlider = new System.Windows.Forms.Panel();
            this.bottombarDesign2 = new System.Windows.Forms.Panel();
            this.bottombarDesign1 = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.topbarDesign1 = new System.Windows.Forms.Panel();
            this.topbarDesign2 = new System.Windows.Forms.Panel();
            this.removeBtn = new System.Windows.Forms.Button();
            this.middlebarDesign1 = new System.Windows.Forms.Panel();
            this.middlebarDesign2 = new System.Windows.Forms.Panel();
            this.middlebarShadow = new System.Windows.Forms.Panel();
            this.middleBar = new System.Windows.Forms.Panel();
            this.songList = new System.Windows.Forms.ListBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.titleBar.SuspendLayout();
            this.bottomBar.SuspendLayout();
            this.volumeBar.SuspendLayout();
            this.trackBar.SuspendLayout();
            this.middleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.titleBar.Controls.Add(this.minBtn_light);
            this.titleBar.Controls.Add(this.closeBtn_light);
            this.titleBar.Controls.Add(this.title);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(448, 40);
            this.titleBar.TabIndex = 0;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drag);
            // 
            // minBtn_light
            // 
            this.minBtn_light.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.minBtn_light.FlatAppearance.BorderSize = 0;
            this.minBtn_light.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.minBtn_light.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.minBtn_light.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn_light.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBtn_light.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.minBtn_light.Location = new System.Drawing.Point(380, 8);
            this.minBtn_light.Name = "minBtn_light";
            this.minBtn_light.Size = new System.Drawing.Size(25, 25);
            this.minBtn_light.TabIndex = 2;
            this.minBtn_light.Text = "-";
            this.minBtn_light.UseVisualStyleBackColor = false;
            this.minBtn_light.Click += new System.EventHandler(this.minBtn_Click);
            this.minBtn_light.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            this.minBtn_light.MouseHover += new System.EventHandler(this.BtnMouseHover);
            // 
            // closeBtn_light
            // 
            this.closeBtn_light.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.closeBtn_light.FlatAppearance.BorderSize = 0;
            this.closeBtn_light.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.closeBtn_light.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.closeBtn_light.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn_light.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn_light.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.closeBtn_light.Location = new System.Drawing.Point(411, 8);
            this.closeBtn_light.Name = "closeBtn_light";
            this.closeBtn_light.Size = new System.Drawing.Size(25, 25);
            this.closeBtn_light.TabIndex = 1;
            this.closeBtn_light.Text = "X";
            this.closeBtn_light.UseVisualStyleBackColor = false;
            this.closeBtn_light.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn_light.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            this.closeBtn_light.MouseHover += new System.EventHandler(this.BtnMouseHover);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.title.Location = new System.Drawing.Point(9, 5);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(171, 30);
            this.title.TabIndex = 1;
            this.title.Text = "ZYNプレーヤー";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drag);
            // 
            // bottombarShadow
            // 
            this.bottombarShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(136)))), ((int)(((byte)(119)))));
            this.bottombarShadow.Location = new System.Drawing.Point(14, 404);
            this.bottombarShadow.Name = "bottombarShadow";
            this.bottombarShadow.Size = new System.Drawing.Size(422, 66);
            this.bottombarShadow.TabIndex = 1;
            // 
            // bottomBar
            // 
            this.bottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.bottomBar.Controls.Add(this.volumeBar);
            this.bottomBar.Controls.Add(this.playBtn);
            this.bottomBar.Controls.Add(this.trackBar);
            this.bottomBar.Controls.Add(this.bottombarDesign2);
            this.bottomBar.Controls.Add(this.bottombarDesign1);
            this.bottomBar.Location = new System.Drawing.Point(11, 401);
            this.bottomBar.Name = "bottomBar";
            this.bottomBar.Size = new System.Drawing.Size(422, 66);
            this.bottomBar.TabIndex = 2;
            // 
            // volumeBar
            // 
            this.volumeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(175)))), ((int)(((byte)(154)))));
            this.volumeBar.Controls.Add(this.volumebarSlider);
            this.volumeBar.Location = new System.Drawing.Point(400, 7);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(8, 52);
            this.volumeBar.TabIndex = 5;
            // 
            // volumebarSlider
            // 
            this.volumebarSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.volumebarSlider.Location = new System.Drawing.Point(0, 22);
            this.volumebarSlider.Name = "volumebarSlider";
            this.volumebarSlider.Size = new System.Drawing.Size(8, 8);
            this.volumebarSlider.TabIndex = 5;
            this.volumebarSlider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.volumeMove);
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.playBtn.BackgroundImage = global::zynplayer.Properties.Resources.playBtn;
            this.playBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.playBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.playBtn.Location = new System.Drawing.Point(192, 6);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(38, 38);
            this.playBtn.TabIndex = 3;
            this.playBtn.Tag = "playBtn";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            this.playBtn.MouseLeave += new System.EventHandler(this.ImageBtnMouseLeave);
            this.playBtn.MouseHover += new System.EventHandler(this.ImageBtnMouseHover);
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(175)))), ((int)(((byte)(154)))));
            this.trackBar.Controls.Add(this.trackbarSlider);
            this.trackBar.Location = new System.Drawing.Point(27, 51);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(368, 8);
            this.trackBar.TabIndex = 4;
            // 
            // trackbarSlider
            // 
            this.trackbarSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.trackbarSlider.Location = new System.Drawing.Point(0, 0);
            this.trackbarSlider.Name = "trackbarSlider";
            this.trackbarSlider.Size = new System.Drawing.Size(8, 8);
            this.trackbarSlider.TabIndex = 5;
            // 
            // bottombarDesign2
            // 
            this.bottombarDesign2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.bottombarDesign2.Location = new System.Drawing.Point(18, 0);
            this.bottombarDesign2.Name = "bottombarDesign2";
            this.bottombarDesign2.Size = new System.Drawing.Size(3, 66);
            this.bottombarDesign2.TabIndex = 4;
            // 
            // bottombarDesign1
            // 
            this.bottombarDesign1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.bottombarDesign1.Location = new System.Drawing.Point(0, 0);
            this.bottombarDesign1.Name = "bottombarDesign1";
            this.bottombarDesign1.Size = new System.Drawing.Size(12, 66);
            this.bottombarDesign1.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(175)))), ((int)(((byte)(154)))));
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.addBtn.Location = new System.Drawing.Point(108, 50);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 25);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "ADD";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            this.addBtn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            this.addBtn.MouseHover += new System.EventHandler(this.BtnMouseHover);
            // 
            // topbarDesign1
            // 
            this.topbarDesign1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(175)))), ((int)(((byte)(154)))));
            this.topbarDesign1.Location = new System.Drawing.Point(11, 50);
            this.topbarDesign1.Name = "topbarDesign1";
            this.topbarDesign1.Size = new System.Drawing.Size(12, 25);
            this.topbarDesign1.TabIndex = 4;
            // 
            // topbarDesign2
            // 
            this.topbarDesign2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(175)))), ((int)(((byte)(154)))));
            this.topbarDesign2.Location = new System.Drawing.Point(29, 50);
            this.topbarDesign2.Name = "topbarDesign2";
            this.topbarDesign2.Size = new System.Drawing.Size(3, 25);
            this.topbarDesign2.TabIndex = 5;
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(175)))), ((int)(((byte)(154)))));
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.removeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.removeBtn.Location = new System.Drawing.Point(240, 50);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(100, 25);
            this.removeBtn.TabIndex = 6;
            this.removeBtn.Text = "REMOVE";
            this.removeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            this.removeBtn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            this.removeBtn.MouseHover += new System.EventHandler(this.BtnMouseHover);
            // 
            // middlebarDesign1
            // 
            this.middlebarDesign1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(175)))), ((int)(((byte)(154)))));
            this.middlebarDesign1.Location = new System.Drawing.Point(12, 100);
            this.middlebarDesign1.Name = "middlebarDesign1";
            this.middlebarDesign1.Size = new System.Drawing.Size(12, 276);
            this.middlebarDesign1.TabIndex = 5;
            // 
            // middlebarDesign2
            // 
            this.middlebarDesign2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(175)))), ((int)(((byte)(154)))));
            this.middlebarDesign2.Location = new System.Drawing.Point(29, 100);
            this.middlebarDesign2.Name = "middlebarDesign2";
            this.middlebarDesign2.Size = new System.Drawing.Size(3, 276);
            this.middlebarDesign2.TabIndex = 6;
            // 
            // middlebarShadow
            // 
            this.middlebarShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(136)))), ((int)(((byte)(119)))));
            this.middlebarShadow.Location = new System.Drawing.Point(70, 100);
            this.middlebarShadow.Name = "middlebarShadow";
            this.middlebarShadow.Size = new System.Drawing.Size(366, 276);
            this.middlebarShadow.TabIndex = 6;
            // 
            // middleBar
            // 
            this.middleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.middleBar.Controls.Add(this.songList);
            this.middleBar.Location = new System.Drawing.Point(67, 97);
            this.middleBar.Name = "middleBar";
            this.middleBar.Size = new System.Drawing.Size(366, 276);
            this.middleBar.TabIndex = 7;
            // 
            // songList
            // 
            this.songList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.songList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.songList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.songList.FormattingEnabled = true;
            this.songList.ItemHeight = 30;
            this.songList.Location = new System.Drawing.Point(0, 0);
            this.songList.Name = "songList";
            this.songList.Size = new System.Drawing.Size(366, 270);
            this.songList.TabIndex = 0;
            this.songList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawItem);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 482);
            this.Controls.Add(this.middleBar);
            this.Controls.Add(this.middlebarShadow);
            this.Controls.Add(this.middlebarDesign2);
            this.Controls.Add(this.middlebarDesign1);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.topbarDesign2);
            this.Controls.Add(this.topbarDesign1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.bottomBar);
            this.Controls.Add(this.bottombarShadow);
            this.Controls.Add(this.titleBar);
            this.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zynplayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.bottomBar.ResumeLayout(false);
            this.volumeBar.ResumeLayout(false);
            this.trackBar.ResumeLayout(false);
            this.middleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button closeBtn_light;
        private System.Windows.Forms.Button minBtn_light;
        private System.Windows.Forms.Panel bottombarShadow;
        private System.Windows.Forms.Panel bottomBar;
        private System.Windows.Forms.Panel bottombarDesign1;
        private System.Windows.Forms.Panel bottombarDesign2;
        private System.Windows.Forms.Panel trackBar;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Panel trackbarSlider;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel topbarDesign1;
        private System.Windows.Forms.Panel topbarDesign2;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Panel middlebarDesign1;
        private System.Windows.Forms.Panel middlebarDesign2;
        private System.Windows.Forms.Panel middlebarShadow;
        private System.Windows.Forms.Panel middleBar;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Panel volumeBar;
        private System.Windows.Forms.Panel volumebarSlider;
        private System.Windows.Forms.Timer timer;
    }
}

