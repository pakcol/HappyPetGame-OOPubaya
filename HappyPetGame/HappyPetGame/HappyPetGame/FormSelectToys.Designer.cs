
namespace HappyPetGame
{
    partial class FormSelectToys
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxToys = new System.Windows.Forms.ComboBox();
            this.labelToysData = new System.Windows.Forms.Label();
            this.linkLabelBuyToys = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUse = new System.Windows.Forms.Button();
            this.pictureBoxToys = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToys)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Toys";
            // 
            // comboBoxToys
            // 
            this.comboBoxToys.FormattingEnabled = true;
            this.comboBoxToys.Location = new System.Drawing.Point(51, 62);
            this.comboBoxToys.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxToys.Name = "comboBoxToys";
            this.comboBoxToys.Size = new System.Drawing.Size(82, 21);
            this.comboBoxToys.TabIndex = 1;
            this.comboBoxToys.SelectedIndexChanged += new System.EventHandler(this.comboBoxToys_SelectedIndexChanged);
            // 
            // labelToysData
            // 
            this.labelToysData.BackColor = System.Drawing.Color.FloralWhite;
            this.labelToysData.Location = new System.Drawing.Point(33, 179);
            this.labelToysData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelToysData.Name = "labelToysData";
            this.labelToysData.Size = new System.Drawing.Size(119, 42);
            this.labelToysData.TabIndex = 3;
            this.labelToysData.Text = "Toys Data";
            this.labelToysData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelBuyToys
            // 
            this.linkLabelBuyToys.AutoSize = true;
            this.linkLabelBuyToys.Location = new System.Drawing.Point(131, 276);
            this.linkLabelBuyToys.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelBuyToys.Name = "linkLabelBuyToys";
            this.linkLabelBuyToys.Size = new System.Drawing.Size(54, 13);
            this.linkLabelBuyToys.TabIndex = 4;
            this.linkLabelBuyToys.TabStop = true;
            this.linkLabelBuyToys.Text = "Buy Here ";
            this.linkLabelBuyToys.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBuyToys_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Russo One", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dont Have a Toys?";
            // 
            // buttonUse
            // 
            this.buttonUse.BackColor = System.Drawing.Color.Moccasin;
            this.buttonUse.CausesValidation = false;
            this.buttonUse.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUse.Location = new System.Drawing.Point(23, 238);
            this.buttonUse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUse.Name = "buttonUse";
            this.buttonUse.Size = new System.Drawing.Size(139, 32);
            this.buttonUse.TabIndex = 6;
            this.buttonUse.Text = "Use";
            this.buttonUse.UseVisualStyleBackColor = false;
            this.buttonUse.Click += new System.EventHandler(this.buttonUse_Click);
            // 
            // pictureBoxToys
            // 
            this.pictureBoxToys.Location = new System.Drawing.Point(51, 84);
            this.pictureBoxToys.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxToys.Name = "pictureBoxToys";
            this.pictureBoxToys.Size = new System.Drawing.Size(87, 93);
            this.pictureBoxToys.TabIndex = 2;
            this.pictureBoxToys.TabStop = false;
            // 
            // FormSelectToys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(195, 292);
            this.Controls.Add(this.buttonUse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabelBuyToys);
            this.Controls.Add(this.labelToysData);
            this.Controls.Add(this.pictureBoxToys);
            this.Controls.Add(this.comboBoxToys);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSelectToys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSelectToys";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSelectToys_FormClosing);
            this.Load += new System.EventHandler(this.FormSelectToys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxToys;
        private System.Windows.Forms.PictureBox pictureBoxToys;
        private System.Windows.Forms.Label labelToysData;
        private System.Windows.Forms.LinkLabel linkLabelBuyToys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUse;
    }
}