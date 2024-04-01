namespace Suit
{
    partial class ChooseSuit
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
            this.buttonLetsPlay = new System.Windows.Forms.Button();
            this.radioButtonKertas = new System.Windows.Forms.RadioButton();
            this.radioButtonBatu = new System.Windows.Forms.RadioButton();
            this.radioButtonGunting = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonLetsPlay
            // 
            this.buttonLetsPlay.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonLetsPlay.Font = new System.Drawing.Font("Singkong", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetsPlay.Location = new System.Drawing.Point(261, 294);
            this.buttonLetsPlay.Name = "buttonLetsPlay";
            this.buttonLetsPlay.Size = new System.Drawing.Size(247, 76);
            this.buttonLetsPlay.TabIndex = 14;
            this.buttonLetsPlay.Text = "Choose !";
            this.buttonLetsPlay.UseVisualStyleBackColor = false;
            this.buttonLetsPlay.Click += new System.EventHandler(this.ButtonLetsPlay_Click);
            // 
            // radioButtonKertas
            // 
            this.radioButtonKertas.BackgroundImage = global::Suit.Properties.Resources.kertas1;
            this.radioButtonKertas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonKertas.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonKertas.Font = new System.Drawing.Font("Singkong", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKertas.Location = new System.Drawing.Point(32, 54);
            this.radioButtonKertas.Name = "radioButtonKertas";
            this.radioButtonKertas.Size = new System.Drawing.Size(196, 187);
            this.radioButtonKertas.TabIndex = 15;
            this.radioButtonKertas.TabStop = true;
            this.radioButtonKertas.Text = "Kertas";
            this.radioButtonKertas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonKertas.UseVisualStyleBackColor = true;
            // 
            // radioButtonBatu
            // 
            this.radioButtonBatu.BackgroundImage = global::Suit.Properties.Resources.batu1;
            this.radioButtonBatu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonBatu.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonBatu.Font = new System.Drawing.Font("Singkong", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBatu.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.radioButtonBatu.Location = new System.Drawing.Point(286, 54);
            this.radioButtonBatu.Name = "radioButtonBatu";
            this.radioButtonBatu.Size = new System.Drawing.Size(196, 187);
            this.radioButtonBatu.TabIndex = 16;
            this.radioButtonBatu.TabStop = true;
            this.radioButtonBatu.Text = "Batu";
            this.radioButtonBatu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonBatu.UseVisualStyleBackColor = true;
            // 
            // radioButtonGunting
            // 
            this.radioButtonGunting.BackgroundImage = global::Suit.Properties.Resources.gunting1;
            this.radioButtonGunting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonGunting.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonGunting.Font = new System.Drawing.Font("Singkong", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGunting.Location = new System.Drawing.Point(533, 54);
            this.radioButtonGunting.Name = "radioButtonGunting";
            this.radioButtonGunting.Size = new System.Drawing.Size(196, 187);
            this.radioButtonGunting.TabIndex = 17;
            this.radioButtonGunting.TabStop = true;
            this.radioButtonGunting.Text = "Gunting";
            this.radioButtonGunting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonGunting.UseVisualStyleBackColor = true;
            // 
            // ChooseSuit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(765, 413);
            this.Controls.Add(this.radioButtonGunting);
            this.Controls.Add(this.radioButtonBatu);
            this.Controls.Add(this.radioButtonKertas);
            this.Controls.Add(this.buttonLetsPlay);
            this.Name = "ChooseSuit";
            this.Text = "ChooseSuit";
            this.Load += new System.EventHandler(this.ChooseSuit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLetsPlay;
        private System.Windows.Forms.RadioButton radioButtonKertas;
        private System.Windows.Forms.RadioButton radioButtonBatu;
        private System.Windows.Forms.RadioButton radioButtonGunting;
    }
}