
namespace HappyPetGame
{
    partial class FormSuit
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
            this.timerAI = new System.Windows.Forms.Timer(this.components);
            this.buttonBattle = new System.Windows.Forms.Button();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxBot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBot)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBattle
            // 
            this.buttonBattle.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonBattle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBattle.Location = new System.Drawing.Point(199, 177);
            this.buttonBattle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBattle.Name = "buttonBattle";
            this.buttonBattle.Size = new System.Drawing.Size(185, 62);
            this.buttonBattle.TabIndex = 17;
            this.buttonBattle.Text = "GO BATTLE!";
            this.buttonBattle.UseVisualStyleBackColor = false;
            this.buttonBattle.Click += new System.EventHandler(this.buttonBattle_Click);
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlayer.Location = new System.Drawing.Point(29, 27);
            this.pictureBoxPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(120, 113);
            this.pictureBoxPlayer.TabIndex = 16;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // pictureBoxBot
            // 
            this.pictureBoxBot.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBot.Location = new System.Drawing.Point(418, 27);
            this.pictureBoxBot.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBot.Name = "pictureBoxBot";
            this.pictureBoxBot.Size = new System.Drawing.Size(120, 113);
            this.pictureBoxBot.TabIndex = 15;
            this.pictureBoxBot.TabStop = false;
            // 
            // FormSuit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(600, 272);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.pictureBoxBot);
            this.Controls.Add(this.buttonBattle);
            this.Name = "FormSuit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSuit";
            this.Load += new System.EventHandler(this.FormSuit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.PictureBox pictureBoxBot;
        private System.Windows.Forms.Timer timerAI;
        private System.Windows.Forms.Button buttonBattle;
    }
}