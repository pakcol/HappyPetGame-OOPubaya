
namespace HappyPetGame
{
    partial class FormToysShop
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
            this.labelToyData1 = new System.Windows.Forms.Label();
            this.labelToyData2 = new System.Windows.Forms.Label();
            this.labelToyData3 = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.radioButtonToy1 = new System.Windows.Forms.RadioButton();
            this.radioButtonToy3 = new System.Windows.Forms.RadioButton();
            this.radioButtonToy2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelToyData1
            // 
            this.labelToyData1.BackColor = System.Drawing.Color.FloralWhite;
            this.labelToyData1.Location = new System.Drawing.Point(88, 304);
            this.labelToyData1.Name = "labelToyData1";
            this.labelToyData1.Size = new System.Drawing.Size(161, 90);
            this.labelToyData1.TabIndex = 4;
            this.labelToyData1.Text = "Toys Data";
            this.labelToyData1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelToyData2
            // 
            this.labelToyData2.BackColor = System.Drawing.Color.FloralWhite;
            this.labelToyData2.Location = new System.Drawing.Point(321, 304);
            this.labelToyData2.Name = "labelToyData2";
            this.labelToyData2.Size = new System.Drawing.Size(165, 90);
            this.labelToyData2.TabIndex = 5;
            this.labelToyData2.Text = "Toys Data";
            this.labelToyData2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelToyData3
            // 
            this.labelToyData3.BackColor = System.Drawing.Color.FloralWhite;
            this.labelToyData3.Location = new System.Drawing.Point(586, 304);
            this.labelToyData3.Name = "labelToyData3";
            this.labelToyData3.Size = new System.Drawing.Size(150, 90);
            this.labelToyData3.TabIndex = 6;
            this.labelToyData3.Text = "Toys Data";
            this.labelToyData3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(335, 397);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(126, 54);
            this.buttonBuy.TabIndex = 7;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // radioButtonToy1
            // 
            this.radioButtonToy1.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonToy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonToy1.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonToy1.Location = new System.Drawing.Point(69, 139);
            this.radioButtonToy1.Name = "radioButtonToy1";
            this.radioButtonToy1.Size = new System.Drawing.Size(180, 162);
            this.radioButtonToy1.TabIndex = 8;
            this.radioButtonToy1.TabStop = true;
            this.radioButtonToy1.UseVisualStyleBackColor = false;
            // 
            // radioButtonToy3
            // 
            this.radioButtonToy3.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonToy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonToy3.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonToy3.Location = new System.Drawing.Point(565, 139);
            this.radioButtonToy3.Name = "radioButtonToy3";
            this.radioButtonToy3.Size = new System.Drawing.Size(171, 162);
            this.radioButtonToy3.TabIndex = 9;
            this.radioButtonToy3.TabStop = true;
            this.radioButtonToy3.UseVisualStyleBackColor = false;
            // 
            // radioButtonToy2
            // 
            this.radioButtonToy2.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonToy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonToy2.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonToy2.Location = new System.Drawing.Point(315, 139);
            this.radioButtonToy2.Name = "radioButtonToy2";
            this.radioButtonToy2.Size = new System.Drawing.Size(171, 162);
            this.radioButtonToy2.TabIndex = 9;
            this.radioButtonToy2.TabStop = true;
            this.radioButtonToy2.UseVisualStyleBackColor = false;
            // 
            // FormToysShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyPetGame.Properties.Resources.shop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonToy2);
            this.Controls.Add(this.radioButtonToy3);
            this.Controls.Add(this.radioButtonToy1);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.labelToyData3);
            this.Controls.Add(this.labelToyData2);
            this.Controls.Add(this.labelToyData1);
            this.Name = "FormToysShop";
            this.Text = "FormToysShop";
            this.Load += new System.EventHandler(this.FormToysShop_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelToyData1;
        private System.Windows.Forms.Label labelToyData2;
        private System.Windows.Forms.Label labelToyData3;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.RadioButton radioButtonToy1;
        private System.Windows.Forms.RadioButton radioButtonToy3;
        private System.Windows.Forms.RadioButton radioButtonToy2;
    }
}