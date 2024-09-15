namespace MusicPlayer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            wykonawcaLabel = new Label();
            button2 = new Button();
            label1 = new Label();
            PlayBTN = new Button();
            menuStrip1 = new MenuStrip();
            muzykaToolStripMenuItem = new ToolStripMenuItem();
            AddMusicMenu = new ToolStripMenuItem();
            MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            groupBox4.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MediaPlayer).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(64, 64, 64);
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(269, 433);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(64, 64, 64);
            groupBox2.Location = new Point(287, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(648, 433);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(64, 64, 64);
            groupBox3.Location = new Point(941, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(188, 433);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(64, 64, 64);
            groupBox4.Controls.Add(MediaPlayer);
            groupBox4.Controls.Add(wykonawcaLabel);
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(PlayBTN);
            groupBox4.Dock = DockStyle.Bottom;
            groupBox4.Location = new Point(0, 468);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1141, 100);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // wykonawcaLabel
            // 
            wykonawcaLabel.AutoSize = true;
            wykonawcaLabel.Location = new Point(246, 22);
            wykonawcaLabel.Name = "wykonawcaLabel";
            wykonawcaLabel.Size = new Size(0, 15);
            wykonawcaLabel.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(84, 22);
            button2.Name = "button2";
            button2.Size = new Size(66, 60);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 22);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Wykonawca";
            // 
            // PlayBTN
            // 
            PlayBTN.AccessibleRole = AccessibleRole.ButtonMenu;
            PlayBTN.BackgroundImageLayout = ImageLayout.Zoom;
            PlayBTN.Image = (Image)resources.GetObject("PlayBTN.Image");
            PlayBTN.Location = new Point(12, 22);
            PlayBTN.Name = "PlayBTN";
            PlayBTN.Size = new Size(66, 60);
            PlayBTN.TabIndex = 0;
            PlayBTN.UseVisualStyleBackColor = true;
            PlayBTN.Click += PlayBTN_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(64, 64, 64);
            menuStrip1.Items.AddRange(new ToolStripItem[] { muzykaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1141, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // muzykaToolStripMenuItem
            // 
            muzykaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddMusicMenu });
            muzykaToolStripMenuItem.Name = "muzykaToolStripMenuItem";
            muzykaToolStripMenuItem.Size = new Size(60, 20);
            muzykaToolStripMenuItem.Text = "Muzyka";
            // 
            // AddMusicMenu
            // 
            AddMusicMenu.Name = "AddMusicMenu";
            AddMusicMenu.Size = new Size(105, 22);
            AddMusicMenu.Text = "Dodaj";
            AddMusicMenu.Click += AddMusicMenu_Click;
            // 
            // MediaPlayer
            // 
            MediaPlayer.Enabled = true;
            MediaPlayer.Location = new Point(303, 21);
            MediaPlayer.Name = "MediaPlayer";
            MediaPlayer.OcxState = (AxHost.State)resources.GetObject("MediaPlayer.OcxState");
            MediaPlayer.Size = new Size(632, 61);
            MediaPlayer.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1141, 568);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Music Player";
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MediaPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem muzykaToolStripMenuItem;
        private ToolStripMenuItem AddMusicMenu;
        private Button button2;
        private Button PlayBTN;
        private Label wykonawcaLabel;
        private Label label1;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
    }
}
