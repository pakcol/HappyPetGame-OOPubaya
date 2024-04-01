
namespace HappyPetGame
{
    partial class FormSelectMinigames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectMinigames));
            this.buttonSnake = new System.Windows.Forms.Button();
            this.buttonSuit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSnake = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSnake
            // 
            this.buttonSnake.BackColor = System.Drawing.Color.Turquoise;
            this.buttonSnake.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSnake.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSnake.ForeColor = System.Drawing.Color.White;
            this.buttonSnake.Location = new System.Drawing.Point(38, 209);
            this.buttonSnake.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSnake.Name = "buttonSnake";
            this.buttonSnake.Size = new System.Drawing.Size(185, 37);
            this.buttonSnake.TabIndex = 7;
            this.buttonSnake.Text = "Snake Game";
            this.buttonSnake.UseVisualStyleBackColor = false;
            this.buttonSnake.Click += new System.EventHandler(this.buttonSnake_Click);
            // 
            // buttonSuit
            // 
            this.buttonSuit.BackColor = System.Drawing.Color.Turquoise;
            this.buttonSuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSuit.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuit.ForeColor = System.Drawing.Color.White;
            this.buttonSuit.Location = new System.Drawing.Point(268, 209);
            this.buttonSuit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSuit.Name = "buttonSuit";
            this.buttonSuit.Size = new System.Drawing.Size(185, 37);
            this.buttonSuit.TabIndex = 8;
            this.buttonSuit.Text = "Rock Paper Scissors";
            this.buttonSuit.UseVisualStyleBackColor = false;
            this.buttonSuit.Click += new System.EventHandler(this.buttonSuit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(268, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 162);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxSnake
            // 
            this.pictureBoxSnake.BackColor = System.Drawing.Color.Khaki;
            this.pictureBoxSnake.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSnake.BackgroundImage")));
            this.pictureBoxSnake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSnake.Location = new System.Drawing.Point(38, 25);
            this.pictureBoxSnake.Name = "pictureBoxSnake";
            this.pictureBoxSnake.Size = new System.Drawing.Size(185, 162);
            this.pictureBoxSnake.TabIndex = 9;
            this.pictureBoxSnake.TabStop = false;
            // 
            // FormSelectMinigames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(487, 257);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxSnake);
            this.Controls.Add(this.buttonSuit);
            this.Controls.Add(this.buttonSnake);
            this.Name = "FormSelectMinigames";
            this.Text = "FormSelectMinigames";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSelectMinigames_FormClosing);
            this.Load += new System.EventHandler(this.FormSelectMinigames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSnake;
        private System.Windows.Forms.Button buttonSuit;
        private System.Windows.Forms.PictureBox pictureBoxSnake;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}