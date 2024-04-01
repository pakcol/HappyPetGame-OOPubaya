
namespace HappyPetGame
{
    partial class FormGame
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resatGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelData = new System.Windows.Forms.Panel();
            this.labelPetData = new System.Windows.Forms.Label();
            this.labelPlayerData = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.panelActivity = new System.Windows.Forms.Panel();
            this.buttonSleep = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonVaccine = new System.Windows.Forms.Button();
            this.buttonBath = new System.Windows.Forms.Button();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPet = new System.Windows.Forms.PictureBox();
            this.timerActivity = new System.Windows.Forms.Timer(this.components);
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.buttonMinigames = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playGameToolStripMenuItem,
            this.resatGameToolStripMenuItem,
            this.changePetToolStripMenuItem});
            this.gameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // playGameToolStripMenuItem
            // 
            this.playGameToolStripMenuItem.Name = "playGameToolStripMenuItem";
            this.playGameToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.playGameToolStripMenuItem.Text = "Play Game";
            this.playGameToolStripMenuItem.Click += new System.EventHandler(this.playGameToolStripMenuItem_Click);
            // 
            // resatGameToolStripMenuItem
            // 
            this.resatGameToolStripMenuItem.Name = "resatGameToolStripMenuItem";
            this.resatGameToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.resatGameToolStripMenuItem.Text = "Resat Game";
            this.resatGameToolStripMenuItem.Click += new System.EventHandler(this.resatGameToolStripMenuItem_Click);
            // 
            // changePetToolStripMenuItem
            // 
            this.changePetToolStripMenuItem.Name = "changePetToolStripMenuItem";
            this.changePetToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.changePetToolStripMenuItem.Text = "Change Pet";
            this.changePetToolStripMenuItem.Click += new System.EventHandler(this.changePetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.Transparent;
            this.panelData.Controls.Add(this.labelPetData);
            this.panelData.Controls.Add(this.labelPlayerData);
            this.panelData.Controls.Add(this.labelDate);
            this.panelData.Location = new System.Drawing.Point(0, 25);
            this.panelData.Margin = new System.Windows.Forms.Padding(2);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(600, 68);
            this.panelData.TabIndex = 1;
            // 
            // labelPetData
            // 
            this.labelPetData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPetData.BackColor = System.Drawing.Color.Orange;
            this.labelPetData.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetData.Location = new System.Drawing.Point(104, 3);
            this.labelPetData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPetData.Name = "labelPetData";
            this.labelPetData.Size = new System.Drawing.Size(359, 65);
            this.labelPetData.TabIndex = 2;
            this.labelPetData.Text = "labelPetData";
            this.labelPetData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPlayerData
            // 
            this.labelPlayerData.AutoSize = true;
            this.labelPlayerData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerData.Location = new System.Drawing.Point(10, 3);
            this.labelPlayerData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayerData.Name = "labelPlayerData";
            this.labelPlayerData.Size = new System.Drawing.Size(96, 13);
            this.labelPlayerData.TabIndex = 1;
            this.labelPlayerData.Text = "labelPlayerData";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(467, 3);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(88, 13);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "labelDateTime";
            // 
            // panelActivity
            // 
            this.panelActivity.BackColor = System.Drawing.Color.Transparent;
            this.panelActivity.Controls.Add(this.buttonSleep);
            this.panelActivity.Controls.Add(this.buttonPlay);
            this.panelActivity.Controls.Add(this.buttonClean);
            this.panelActivity.Controls.Add(this.buttonVaccine);
            this.panelActivity.Controls.Add(this.buttonBath);
            this.panelActivity.Controls.Add(this.buttonFeed);
            this.panelActivity.Location = new System.Drawing.Point(0, 297);
            this.panelActivity.Margin = new System.Windows.Forms.Padding(2);
            this.panelActivity.Name = "panelActivity";
            this.panelActivity.Size = new System.Drawing.Size(600, 53);
            this.panelActivity.TabIndex = 2;
            // 
            // buttonSleep
            // 
            this.buttonSleep.BackColor = System.Drawing.Color.Blue;
            this.buttonSleep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSleep.ForeColor = System.Drawing.Color.White;
            this.buttonSleep.Location = new System.Drawing.Point(503, 9);
            this.buttonSleep.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSleep.Name = "buttonSleep";
            this.buttonSleep.Size = new System.Drawing.Size(100, 37);
            this.buttonSleep.TabIndex = 5;
            this.buttonSleep.Text = "Sleep";
            this.buttonSleep.UseVisualStyleBackColor = false;
            this.buttonSleep.Click += new System.EventHandler(this.buttonSleep_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Purple;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.White;
            this.buttonPlay.Location = new System.Drawing.Point(106, 9);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(86, 37);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.Text = "PLAY";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClean.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClean.ForeColor = System.Drawing.Color.White;
            this.buttonClean.Location = new System.Drawing.Point(399, 9);
            this.buttonClean.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(100, 37);
            this.buttonClean.TabIndex = 3;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = false;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonVaccine
            // 
            this.buttonVaccine.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonVaccine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVaccine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVaccine.ForeColor = System.Drawing.Color.White;
            this.buttonVaccine.Location = new System.Drawing.Point(295, 9);
            this.buttonVaccine.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVaccine.Name = "buttonVaccine";
            this.buttonVaccine.Size = new System.Drawing.Size(100, 37);
            this.buttonVaccine.TabIndex = 2;
            this.buttonVaccine.Text = "Vaccinate";
            this.buttonVaccine.UseVisualStyleBackColor = false;
            this.buttonVaccine.Click += new System.EventHandler(this.buttonVaccine_Click);
            // 
            // buttonBath
            // 
            this.buttonBath.BackColor = System.Drawing.Color.Cyan;
            this.buttonBath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBath.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBath.ForeColor = System.Drawing.Color.White;
            this.buttonBath.Location = new System.Drawing.Point(196, 9);
            this.buttonBath.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBath.Name = "buttonBath";
            this.buttonBath.Size = new System.Drawing.Size(95, 37);
            this.buttonBath.TabIndex = 1;
            this.buttonBath.Text = "Bath";
            this.buttonBath.UseVisualStyleBackColor = false;
            this.buttonBath.Click += new System.EventHandler(this.buttonBath_Click);
            // 
            // buttonFeed
            // 
            this.buttonFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonFeed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFeed.ForeColor = System.Drawing.Color.White;
            this.buttonFeed.Location = new System.Drawing.Point(2, 9);
            this.buttonFeed.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(100, 37);
            this.buttonFeed.TabIndex = 0;
            this.buttonFeed.Text = "Feed";
            this.buttonFeed.UseVisualStyleBackColor = false;
            this.buttonFeed.Click += new System.EventHandler(this.buttonFeed_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(180, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "HAPPY PET GAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPet
            // 
            this.pictureBoxPet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPet.Location = new System.Drawing.Point(196, 116);
            this.pictureBoxPet.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPet.Name = "pictureBoxPet";
            this.pictureBoxPet.Size = new System.Drawing.Size(210, 161);
            this.pictureBoxPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPet.TabIndex = 4;
            this.pictureBoxPet.TabStop = false;
            // 
            // timerActivity
            // 
            this.timerActivity.Tick += new System.EventHandler(this.timerActivity_Tick);
            // 
            // timerGame
            // 
            this.timerGame.Interval = 1000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // buttonMinigames
            // 
            this.buttonMinigames.BackColor = System.Drawing.Color.Turquoise;
            this.buttonMinigames.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMinigames.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinigames.ForeColor = System.Drawing.Color.White;
            this.buttonMinigames.Location = new System.Drawing.Point(2, 97);
            this.buttonMinigames.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMinigames.Name = "buttonMinigames";
            this.buttonMinigames.Size = new System.Drawing.Size(109, 37);
            this.buttonMinigames.TabIndex = 6;
            this.buttonMinigames.Text = "Minigames";
            this.buttonMinigames.UseVisualStyleBackColor = false;
            this.buttonMinigames.Click += new System.EventHandler(this.buttonMinigames_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyPetGame.Properties.Resources.Room;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonMinigames);
            this.Controls.Add(this.pictureBoxPet);
            this.Controls.Add(this.panelActivity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Happy Pet Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGame_FormClosing);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.panelActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resatGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelActivity;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonVaccine;
        private System.Windows.Forms.Button buttonBath;
        private System.Windows.Forms.Button buttonFeed;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelPetData;
        public System.Windows.Forms.Label labelPlayerData;
        public System.Windows.Forms.Label labelDate;
        public System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.PictureBox pictureBoxPet;
        private System.Windows.Forms.Button buttonSleep;
        public System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Timer timerActivity;
        private System.Windows.Forms.Button buttonMinigames;
    }
}

