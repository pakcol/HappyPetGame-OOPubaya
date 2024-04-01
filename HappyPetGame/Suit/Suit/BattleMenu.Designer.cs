namespace Suit
{
    partial class BattleMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleMenu));
            this.pictureBoxBot = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.timerAI = new System.Windows.Forms.Timer(this.components);
            this.buttonBattle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBot
            // 
            this.pictureBoxBot.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBot.Location = new System.Drawing.Point(719, 164);
            this.pictureBoxBot.Name = "pictureBoxBot";
            this.pictureBoxBot.Size = new System.Drawing.Size(160, 139);
            this.pictureBoxBot.TabIndex = 3;
            this.pictureBoxBot.TabStop = false;
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlayer.Location = new System.Drawing.Point(187, 164);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(160, 139);
            this.pictureBoxPlayer.TabIndex = 4;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // buttonBattle
            // 
            this.buttonBattle.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonBattle.Font = new System.Drawing.Font("Singkong", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBattle.Location = new System.Drawing.Point(410, 368);
            this.buttonBattle.Name = "buttonBattle";
            this.buttonBattle.Size = new System.Drawing.Size(247, 76);
            this.buttonBattle.TabIndex = 14;
            this.buttonBattle.Text = "GO BATTLE!";
            this.buttonBattle.UseVisualStyleBackColor = false;
            this.buttonBattle.Click += new System.EventHandler(this.ButtonBattle_Click);
            // 
            // BattleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 491);
            this.Controls.Add(this.buttonBattle);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.pictureBoxBot);
            this.DoubleBuffered = true;
            this.Name = "BattleMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BattleMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBot;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.Timer timerAI;
        private System.Windows.Forms.Button buttonBattle;
    }
}

