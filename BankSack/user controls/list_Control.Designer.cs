namespace BankSack
{
    partial class list_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list_Control));
            this.label_Name = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_datum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.White;
            this.label_Name.Location = new System.Drawing.Point(80, 25);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(219, 24);
            this.label_Name.TabIndex = 33;
            this.label_Name.Text = "FirstName LastName";
            // 
            // label_amount
            // 
            this.label_amount.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount.ForeColor = System.Drawing.Color.White;
            this.label_amount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_amount.Location = new System.Drawing.Point(344, 3);
            this.label_amount.Name = "label_amount";
            this.label_amount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_amount.Size = new System.Drawing.Size(366, 35);
            this.label_amount.TabIndex = 34;
            this.label_amount.Text = "€ 0,00";
            this.label_amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label_datum
            // 
            this.label_datum.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_datum.ForeColor = System.Drawing.Color.White;
            this.label_datum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_datum.Location = new System.Drawing.Point(434, 49);
            this.label_datum.Name = "label_datum";
            this.label_datum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_datum.Size = new System.Drawing.Size(276, 24);
            this.label_datum.TabIndex = 36;
            this.label_datum.Text = "1996.10.1020";
            this.label_datum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // list_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.label_datum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.label_Name);
            this.Name = "list_Control";
            this.Size = new System.Drawing.Size(721, 77);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label_Name;
        public System.Windows.Forms.Label label_amount;
        public System.Windows.Forms.Label label_datum;
    }
}
