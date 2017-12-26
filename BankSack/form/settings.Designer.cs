namespace BankSack
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            this.panel_upper = new System.Windows.Forms.Panel();
            this.button_minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.button_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_Iban = new System.Windows.Forms.Label();
            this.label_AccountNum = new System.Windows.Forms.Label();
            this.textbox_Account_login = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Button_save = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.panel_upper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_photo.Image")));
            this.pictureBox_photo.Location = new System.Drawing.Point(12, 39);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_photo.TabIndex = 31;
            this.pictureBox_photo.TabStop = false;
            // 
            // panel_upper
            // 
            this.panel_upper.Controls.Add(this.button_minimize);
            this.panel_upper.Controls.Add(this.button_Close);
            this.panel_upper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_upper.Location = new System.Drawing.Point(0, 0);
            this.panel_upper.Name = "panel_upper";
            this.panel_upper.Size = new System.Drawing.Size(344, 33);
            this.panel_upper.TabIndex = 32;
            this.panel_upper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // button_minimize
            // 
            this.button_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button_minimize.Image = ((System.Drawing.Image)(resources.GetObject("button_minimize.Image")));
            this.button_minimize.ImageActive = null;
            this.button_minimize.Location = new System.Drawing.Point(283, 0);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(30, 30);
            this.button_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_minimize.TabIndex = 8;
            this.button_minimize.TabStop = false;
            this.button_minimize.Zoom = 10;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button_Close.Image = ((System.Drawing.Image)(resources.GetObject("button_Close.Image")));
            this.button_Close.ImageActive = null;
            this.button_Close.Location = new System.Drawing.Point(310, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Close.TabIndex = 7;
            this.button_Close.TabStop = false;
            this.button_Close.Zoom = 10;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FirstName.ForeColor = System.Drawing.Color.White;
            this.label_FirstName.Location = new System.Drawing.Point(118, 47);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(105, 23);
            this.label_FirstName.TabIndex = 33;
            this.label_FirstName.Text = "FirstName";
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account.ForeColor = System.Drawing.Color.White;
            this.Account.Location = new System.Drawing.Point(12, 151);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(95, 23);
            this.Account.TabIndex = 34;
            this.Account.Text = "Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Password";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LastName.ForeColor = System.Drawing.Color.White;
            this.label_LastName.Location = new System.Drawing.Point(118, 70);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(109, 23);
            this.label_LastName.TabIndex = 36;
            this.label_LastName.Text = "LastName";
            // 
            // label_Iban
            // 
            this.label_Iban.AutoSize = true;
            this.label_Iban.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Iban.ForeColor = System.Drawing.Color.White;
            this.label_Iban.Location = new System.Drawing.Point(118, 93);
            this.label_Iban.Name = "label_Iban";
            this.label_Iban.Size = new System.Drawing.Size(55, 23);
            this.label_Iban.TabIndex = 37;
            this.label_Iban.Text = "Iban";
            // 
            // label_AccountNum
            // 
            this.label_AccountNum.AutoSize = true;
            this.label_AccountNum.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AccountNum.ForeColor = System.Drawing.Color.White;
            this.label_AccountNum.Location = new System.Drawing.Point(118, 116);
            this.label_AccountNum.Name = "label_AccountNum";
            this.label_AccountNum.Size = new System.Drawing.Size(141, 23);
            this.label_AccountNum.TabIndex = 38;
            this.label_AccountNum.Text = "AccountNum";
            // 
            // textbox_Account_login
            // 
            this.textbox_Account_login.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.textbox_Account_login.BorderColorIdle = System.Drawing.Color.Silver;
            this.textbox_Account_login.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.textbox_Account_login.BorderThickness = 2;
            this.textbox_Account_login.Cursor = System.Windows.Forms.Cursors.Default;
            this.textbox_Account_login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Account_login.ForeColor = System.Drawing.Color.Silver;
            this.textbox_Account_login.isPassword = false;
            this.textbox_Account_login.Location = new System.Drawing.Point(122, 148);
            this.textbox_Account_login.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_Account_login.Name = "textbox_Account_login";
            this.textbox_Account_login.Size = new System.Drawing.Size(207, 38);
            this.textbox_Account_login.TabIndex = 39;
            this.textbox_Account_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.bunifuMetroTextbox1.BorderThickness = 2;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(122, 191);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(207, 38);
            this.bunifuMetroTextbox1.TabIndex = 40;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Button_save
            // 
            this.Button_save.ActiveBorderThickness = 1;
            this.Button_save.ActiveCornerRadius = 1;
            this.Button_save.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Button_save.ActiveForecolor = System.Drawing.Color.White;
            this.Button_save.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.Button_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_save.BackgroundImage")));
            this.Button_save.ButtonText = "save";
            this.Button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.Button_save.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_save.IdleBorderThickness = 1;
            this.Button_save.IdleCornerRadius = 1;
            this.Button_save.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.Button_save.IdleForecolor = System.Drawing.Color.White;
            this.Button_save.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.Button_save.Location = new System.Drawing.Point(122, 240);
            this.Button_save.Margin = new System.Windows.Forms.Padding(5);
            this.Button_save.Name = "Button_save";
            this.Button_save.Size = new System.Drawing.Size(207, 37);
            this.Button_save.TabIndex = 41;
            this.Button_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_save.Click += new System.EventHandler(this.Button_save_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(344, 291);
            this.Controls.Add(this.Button_save);
            this.Controls.Add(this.bunifuMetroTextbox1);
            this.Controls.Add(this.textbox_Account_login);
            this.Controls.Add(this.label_AccountNum);
            this.Controls.Add(this.label_Iban);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.panel_upper);
            this.Controls.Add(this.pictureBox_photo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.panel_upper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.Panel panel_upper;
        private Bunifu.Framework.UI.BunifuImageButton button_minimize;
        private Bunifu.Framework.UI.BunifuImageButton button_Close;
        private System.Windows.Forms.Label label_AccountNum;
        private System.Windows.Forms.Label label_Iban;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label label_FirstName;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox textbox_Account_login;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_save;
    }
}