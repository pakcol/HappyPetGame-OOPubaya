
namespace HappyPetGame
{
    partial class FormChooseSuit
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
            this.radioButtonGunting = new System.Windows.Forms.RadioButton();
            this.radioButtonBatu = new System.Windows.Forms.RadioButton();
            this.radioButtonKertas = new System.Windows.Forms.RadioButton();
            this.buttonLetsPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonGunting
            // 
            this.radioButtonGunting.BackgroundImage = global::HappyPetGame.Properties.Resources.gunting;
            this.radioButtonGunting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonGunting.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonGunting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGunting.Location = new System.Drawing.Point(389, 11);
            this.radioButtonGunting.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonGunting.Name = "radioButtonGunting";
            this.radioButtonGunting.Size = new System.Drawing.Size(147, 152);
            this.radioButtonGunting.TabIndex = 21;
            this.radioButtonGunting.TabStop = true;
            this.radioButtonGunting.Text = "Gunting";
            this.radioButtonGunting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonGunting.UseVisualStyleBackColor = true;
            // 
            // radioButtonBatu
            // 
            this.radioButtonBatu.BackgroundImage = global::HappyPetGame.Properties.Resources.batu;
            this.radioButtonBatu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonBatu.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonBatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBatu.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.radioButtonBatu.Location = new System.Drawing.Point(203, 11);
            this.radioButtonBatu.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonBatu.Name = "radioButtonBatu";
            this.radioButtonBatu.Size = new System.Drawing.Size(147, 152);
            this.radioButtonBatu.TabIndex = 20;
            this.radioButtonBatu.TabStop = true;
            this.radioButtonBatu.Text = "Batu";
            this.radioButtonBatu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonBatu.UseVisualStyleBackColor = true;
            // 
            // radioButtonKertas
            // 
            this.radioButtonKertas.BackgroundImage = global::HappyPetGame.Properties.Resources.kertas;
            this.radioButtonKertas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonKertas.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonKertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKertas.Location = new System.Drawing.Point(13, 11);
            this.radioButtonKertas.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonKertas.Name = "radioButtonKertas";
            this.radioButtonKertas.Size = new System.Drawing.Size(147, 152);
            this.radioButtonKertas.TabIndex = 19;
            this.radioButtonKertas.TabStop = true;
            this.radioButtonKertas.Text = "Kertas";
            this.radioButtonKertas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonKertas.UseVisualStyleBackColor = true;
            // 
            // buttonLetsPlay
            // 
            this.buttonLetsPlay.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonLetsPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetsPlay.Location = new System.Drawing.Point(187, 204);
            this.buttonLetsPlay.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLetsPlay.Name = "buttonLetsPlay";
            this.buttonLetsPlay.Size = new System.Drawing.Size(185, 62);
            this.buttonLetsPlay.TabIndex = 18;
            this.buttonLetsPlay.Text = "Choose !";
            this.buttonLetsPlay.UseVisualStyleBackColor = false;
            this.buttonLetsPlay.Click += new System.EventHandler(this.buttonLetsPlay_Click);
            // 
            // FormChooseSuit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(551, 291);
            this.Controls.Add(this.radioButtonGunting);
            this.Controls.Add(this.radioButtonBatu);
            this.Controls.Add(this.radioButtonKertas);
            this.Controls.Add(this.buttonLetsPlay);
            this.Name = "FormChooseSuit";
            this.Text = "FormChooseSuit";
            this.Load += new System.EventHandler(this.FormChooseSuit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonGunting;
        private System.Windows.Forms.RadioButton radioButtonBatu;
        private System.Windows.Forms.RadioButton radioButtonKertas;
        private System.Windows.Forms.Button buttonLetsPlay;
    }
}