namespace BankSack
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.button_back = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_main = new System.Windows.Forms.Panel();
            this.Button_settings = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            this.label_accountnummer = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.label_balans_transfer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.button_back)).BeginInit();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.Image = ((System.Drawing.Image)(resources.GetObject("button_back.Image")));
            this.button_back.ImageActive = null;
            this.button_back.Location = new System.Drawing.Point(773, 341);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(71, 71);
            this.button_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_back.TabIndex = 63;
            this.button_back.TabStop = false;
            this.button_back.Zoom = 10;
            this.button_back.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.Button_settings);
            this.panel_main.Controls.Add(this.pictureBox_photo);
            this.panel_main.Controls.Add(this.label_accountnummer);
            this.panel_main.Controls.Add(this.label_user);
            this.panel_main.Controls.Add(this.label_balans_transfer);
            this.panel_main.Location = new System.Drawing.Point(3, 3);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(847, 119);
            this.panel_main.TabIndex = 64;
            // 
            // Button_settings
            // 
            this.Button_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.Button_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_settings.Image = ((System.Drawing.Image)(resources.GetObject("Button_settings.Image")));
            this.Button_settings.ImageActive = null;
            this.Button_settings.Location = new System.Drawing.Point(770, 61);
            this.Button_settings.Name = "Button_settings";
            this.Button_settings.Size = new System.Drawing.Size(50, 50);
            this.Button_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_settings.TabIndex = 65;
            this.Button_settings.TabStop = false;
            this.Button_settings.Zoom = 10;
            this.Button_settings.Click += new System.EventHandler(this.Button_settings_Click);
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_photo.Image")));
            this.pictureBox_photo.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_photo.TabIndex = 30;
            this.pictureBox_photo.TabStop = false;
            // 
            // label_accountnummer
            // 
            this.label_accountnummer.AutoSize = true;
            this.label_accountnummer.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_accountnummer.ForeColor = System.Drawing.Color.White;
            this.label_accountnummer.Location = new System.Drawing.Point(128, 61);
            this.label_accountnummer.Name = "label_accountnummer";
            this.label_accountnummer.Size = new System.Drawing.Size(225, 23);
            this.label_accountnummer.TabIndex = 29;
            this.label_accountnummer.Text = "NL64MAZE 0123456789";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.ForeColor = System.Drawing.Color.White;
            this.label_user.Location = new System.Drawing.Point(126, 12);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(283, 33);
            this.label_user.TabIndex = 28;
            this.label_user.Text = "FirstName LastName";
            // 
            // label_balans_transfer
            // 
            this.label_balans_transfer.Font = new System.Drawing.Font("Century Gothic", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_balans_transfer.ForeColor = System.Drawing.Color.White;
            this.label_balans_transfer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_balans_transfer.Location = new System.Drawing.Point(454, 12);
            this.label_balans_transfer.Name = "label_balans_transfer";
            this.label_balans_transfer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_balans_transfer.Size = new System.Drawing.Size(366, 40);
            this.label_balans_transfer.TabIndex = 26;
            this.label_balans_transfer.Text = "€ 0,00";
            this.label_balans_transfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(15, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 284);
            this.panel1.TabIndex = 65;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.button_back);
            this.Name = "Info";
            this.Size = new System.Drawing.Size(853, 422);
            this.Load += new System.EventHandler(this.Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.button_back)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton button_back;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.Label label_accountnummer;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_balans_transfer;
        private Bunifu.Framework.UI.BunifuImageButton Button_settings;
        private System.Windows.Forms.Panel panel1;
    }
}
