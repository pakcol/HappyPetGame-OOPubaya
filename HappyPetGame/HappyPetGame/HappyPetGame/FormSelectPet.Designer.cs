
namespace HappyPetGame
{
    partial class FormSelectPet
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
            this.comboBoxEnvironment = new System.Windows.Forms.ComboBox();
            this.textBoxPetName = new System.Windows.Forms.TextBox();
            this.labelEnvironment = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLetsPlay = new System.Windows.Forms.Button();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.radioButtonChameleon = new System.Windows.Forms.RadioButton();
            this.radioButtonFish = new System.Windows.Forms.RadioButton();
            this.radioButtonCat = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // comboBoxEnvironment
            // 
            this.comboBoxEnvironment.FormattingEnabled = true;
            this.comboBoxEnvironment.Location = new System.Drawing.Point(465, 284);
            this.comboBoxEnvironment.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEnvironment.Name = "comboBoxEnvironment";
            this.comboBoxEnvironment.Size = new System.Drawing.Size(92, 21);
            this.comboBoxEnvironment.TabIndex = 18;
            // 
            // textBoxPetName
            // 
            this.textBoxPetName.Location = new System.Drawing.Point(199, 284);
            this.textBoxPetName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPetName.Name = "textBoxPetName";
            this.textBoxPetName.Size = new System.Drawing.Size(130, 20);
            this.textBoxPetName.TabIndex = 17;
            // 
            // labelEnvironment
            // 
            this.labelEnvironment.AutoSize = true;
            this.labelEnvironment.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnvironment.Location = new System.Drawing.Point(334, 284);
            this.labelEnvironment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnvironment.Name = "labelEnvironment";
            this.labelEnvironment.Size = new System.Drawing.Size(127, 19);
            this.labelEnvironment.TabIndex = 16;
            this.labelEnvironment.Text = "Environment :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter Your Pet Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select Your New Pet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Enter Your Name :";
            // 
            // buttonLetsPlay
            // 
            this.buttonLetsPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonLetsPlay.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetsPlay.Location = new System.Drawing.Point(199, 353);
            this.buttonLetsPlay.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLetsPlay.Name = "buttonLetsPlay";
            this.buttonLetsPlay.Size = new System.Drawing.Size(179, 31);
            this.buttonLetsPlay.TabIndex = 19;
            this.buttonLetsPlay.Text = "Lets Play";
            this.buttonLetsPlay.UseVisualStyleBackColor = false;
            this.buttonLetsPlay.Click += new System.EventHandler(this.buttonLetsPlay_Click);
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(173, 20);
            this.textBoxPlayerName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(168, 20);
            this.textBoxPlayerName.TabIndex = 24;
            // 
            // radioButtonChameleon
            // 
            this.radioButtonChameleon.BackgroundImage = global::HappyPetGame.Properties.Resources.chameleon_happy;
            this.radioButtonChameleon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonChameleon.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonChameleon.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonChameleon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButtonChameleon.Location = new System.Drawing.Point(386, 99);
            this.radioButtonChameleon.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonChameleon.Name = "radioButtonChameleon";
            this.radioButtonChameleon.Size = new System.Drawing.Size(184, 161);
            this.radioButtonChameleon.TabIndex = 22;
            this.radioButtonChameleon.TabStop = true;
            this.radioButtonChameleon.Text = "Chameleon";
            this.radioButtonChameleon.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.radioButtonChameleon.UseVisualStyleBackColor = true;
            this.radioButtonChameleon.CheckedChanged += new System.EventHandler(this.radioButtonChameleon_CheckedChanged);
            // 
            // radioButtonFish
            // 
            this.radioButtonFish.BackgroundImage = global::HappyPetGame.Properties.Resources.fish_happy;
            this.radioButtonFish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonFish.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonFish.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButtonFish.Location = new System.Drawing.Point(193, 99);
            this.radioButtonFish.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonFish.Name = "radioButtonFish";
            this.radioButtonFish.Size = new System.Drawing.Size(185, 161);
            this.radioButtonFish.TabIndex = 21;
            this.radioButtonFish.TabStop = true;
            this.radioButtonFish.Text = "Fish";
            this.radioButtonFish.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.radioButtonFish.UseVisualStyleBackColor = true;
            this.radioButtonFish.CheckedChanged += new System.EventHandler(this.radioButtonFish_CheckedChanged);
            // 
            // radioButtonCat
            // 
            this.radioButtonCat.BackgroundImage = global::HappyPetGame.Properties.Resources.cat_happy;
            this.radioButtonCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonCat.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonCat.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButtonCat.Location = new System.Drawing.Point(13, 99);
            this.radioButtonCat.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonCat.Name = "radioButtonCat";
            this.radioButtonCat.Size = new System.Drawing.Size(176, 161);
            this.radioButtonCat.TabIndex = 20;
            this.radioButtonCat.TabStop = true;
            this.radioButtonCat.Text = "Cat";
            this.radioButtonCat.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.radioButtonCat.UseVisualStyleBackColor = true;
            this.radioButtonCat.CheckedChanged += new System.EventHandler(this.radioButtonCat_CheckedChanged);
            // 
            // FormSelectPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(611, 399);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButtonChameleon);
            this.Controls.Add(this.radioButtonFish);
            this.Controls.Add(this.radioButtonCat);
            this.Controls.Add(this.buttonLetsPlay);
            this.Controls.Add(this.comboBoxEnvironment);
            this.Controls.Add(this.textBoxPetName);
            this.Controls.Add(this.labelEnvironment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSelectPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSelectPet";
            this.Load += new System.EventHandler(this.FormSelectPet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonChameleon;
        private System.Windows.Forms.RadioButton radioButtonFish;
        private System.Windows.Forms.RadioButton radioButtonCat;
        private System.Windows.Forms.ComboBox comboBoxEnvironment;
        private System.Windows.Forms.TextBox textBoxPetName;
        private System.Windows.Forms.Label labelEnvironment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLetsPlay;
        private System.Windows.Forms.TextBox textBoxPlayerName;
    }
}