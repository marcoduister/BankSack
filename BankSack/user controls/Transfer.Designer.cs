namespace BankSack
{
    partial class Transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfer));
            this.panel_main = new System.Windows.Forms.Panel();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            this.label_accountnummer = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_balans_transfer = new System.Windows.Forms.Label();
            this.textbox_Amount_pennys = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_Amount_dollar = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Textbox_reciever_Account_Nummer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Dropdown_users = new Bunifu.Framework.UI.BunifuDropdown();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_Payment_Refrence = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_back = new Bunifu.Framework.UI.BunifuImageButton();
            this.Button_Send_Money = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.pictureBox_photo);
            this.panel_main.Controls.Add(this.label_accountnummer);
            this.panel_main.Controls.Add(this.label_user);
            this.panel_main.Controls.Add(this.pictureBox1);
            this.panel_main.Controls.Add(this.label_balans_transfer);
            this.panel_main.Location = new System.Drawing.Point(3, 3);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(847, 119);
            this.panel_main.TabIndex = 0;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(770, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
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
            // textbox_Amount_pennys
            // 
            this.textbox_Amount_pennys.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.textbox_Amount_pennys.BorderColorIdle = System.Drawing.Color.Silver;
            this.textbox_Amount_pennys.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.textbox_Amount_pennys.BorderThickness = 2;
            this.textbox_Amount_pennys.Cursor = System.Windows.Forms.Cursors.Default;
            this.textbox_Amount_pennys.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Amount_pennys.ForeColor = System.Drawing.Color.Silver;
            this.textbox_Amount_pennys.isPassword = false;
            this.textbox_Amount_pennys.Location = new System.Drawing.Point(276, 192);
            this.textbox_Amount_pennys.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textbox_Amount_pennys.Name = "textbox_Amount_pennys";
            this.textbox_Amount_pennys.Size = new System.Drawing.Size(61, 38);
            this.textbox_Amount_pennys.TabIndex = 31;
            this.textbox_Amount_pennys.Text = "00";
            this.textbox_Amount_pennys.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Name reciever";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "Account Nummer";
            // 
            // textbox_Amount_dollar
            // 
            this.textbox_Amount_dollar.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.textbox_Amount_dollar.BorderColorIdle = System.Drawing.Color.Silver;
            this.textbox_Amount_dollar.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.textbox_Amount_dollar.BorderThickness = 2;
            this.textbox_Amount_dollar.Cursor = System.Windows.Forms.Cursors.Default;
            this.textbox_Amount_dollar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Amount_dollar.ForeColor = System.Drawing.Color.Silver;
            this.textbox_Amount_dollar.isPassword = false;
            this.textbox_Amount_dollar.Location = new System.Drawing.Point(15, 192);
            this.textbox_Amount_dollar.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textbox_Amount_dollar.Name = "textbox_Amount_dollar";
            this.textbox_Amount_dollar.Size = new System.Drawing.Size(245, 38);
            this.textbox_Amount_dollar.TabIndex = 37;
            this.textbox_Amount_dollar.Text = "00";
            this.textbox_Amount_dollar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Textbox_reciever_Account_Nummer
            // 
            this.Textbox_reciever_Account_Nummer.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.Textbox_reciever_Account_Nummer.BorderColorIdle = System.Drawing.Color.Silver;
            this.Textbox_reciever_Account_Nummer.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.Textbox_reciever_Account_Nummer.BorderThickness = 2;
            this.Textbox_reciever_Account_Nummer.Cursor = System.Windows.Forms.Cursors.Default;
            this.Textbox_reciever_Account_Nummer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_reciever_Account_Nummer.ForeColor = System.Drawing.Color.Silver;
            this.Textbox_reciever_Account_Nummer.isPassword = false;
            this.Textbox_reciever_Account_Nummer.Location = new System.Drawing.Point(154, 333);
            this.Textbox_reciever_Account_Nummer.Margin = new System.Windows.Forms.Padding(7);
            this.Textbox_reciever_Account_Nummer.Name = "Textbox_reciever_Account_Nummer";
            this.Textbox_reciever_Account_Nummer.Size = new System.Drawing.Size(183, 38);
            this.Textbox_reciever_Account_Nummer.TabIndex = 39;
            this.Textbox_reciever_Account_Nummer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Dropdown_users
            // 
            this.Dropdown_users.BackColor = System.Drawing.Color.Transparent;
            this.Dropdown_users.BorderRadius = 2;
            this.Dropdown_users.DisabledColor = System.Drawing.Color.SeaGreen;
            this.Dropdown_users.ForeColor = System.Drawing.Color.White;
            this.Dropdown_users.Items = new string[] {
        ""};
            this.Dropdown_users.Location = new System.Drawing.Point(15, 265);
            this.Dropdown_users.Name = "Dropdown_users";
            this.Dropdown_users.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Dropdown_users.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Dropdown_users.selectedIndex = -1;
            this.Dropdown_users.Size = new System.Drawing.Size(322, 35);
            this.Dropdown_users.TabIndex = 40;
            this.Dropdown_users.onItemSelected += new System.EventHandler(this.Dropdown_users_onItemSelected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(421, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "payment reference";
            // 
            // textbox_Payment_Refrence
            // 
            this.textbox_Payment_Refrence.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.textbox_Payment_Refrence.BorderColorIdle = System.Drawing.Color.Silver;
            this.textbox_Payment_Refrence.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.textbox_Payment_Refrence.BorderThickness = 2;
            this.textbox_Payment_Refrence.Cursor = System.Windows.Forms.Cursors.Default;
            this.textbox_Payment_Refrence.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Payment_Refrence.ForeColor = System.Drawing.Color.Silver;
            this.textbox_Payment_Refrence.isPassword = false;
            this.textbox_Payment_Refrence.Location = new System.Drawing.Point(425, 192);
            this.textbox_Payment_Refrence.Margin = new System.Windows.Forms.Padding(7);
            this.textbox_Payment_Refrence.Name = "textbox_Payment_Refrence";
            this.textbox_Payment_Refrence.Size = new System.Drawing.Size(303, 38);
            this.textbox_Payment_Refrence.TabIndex = 44;
            this.textbox_Payment_Refrence.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 30);
            this.label6.TabIndex = 47;
            this.label6.Text = "NL64MAZE";
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
            this.button_back.TabIndex = 48;
            this.button_back.TabStop = false;
            this.button_back.Zoom = 10;
            this.button_back.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Button_Send_Money
            // 
            this.Button_Send_Money.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Button_Send_Money.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Button_Send_Money.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Send_Money.BorderRadius = 0;
            this.Button_Send_Money.ButtonText = "Send Money";
            this.Button_Send_Money.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Send_Money.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Send_Money.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_Send_Money.Iconimage = ((System.Drawing.Image)(resources.GetObject("Button_Send_Money.Iconimage")));
            this.Button_Send_Money.Iconimage_right = null;
            this.Button_Send_Money.Iconimage_right_Selected = null;
            this.Button_Send_Money.Iconimage_Selected = null;
            this.Button_Send_Money.IconMarginLeft = 0;
            this.Button_Send_Money.IconMarginRight = 0;
            this.Button_Send_Money.IconRightVisible = true;
            this.Button_Send_Money.IconRightZoom = 0D;
            this.Button_Send_Money.IconVisible = true;
            this.Button_Send_Money.IconZoom = 90D;
            this.Button_Send_Money.IsTab = false;
            this.Button_Send_Money.Location = new System.Drawing.Point(425, 265);
            this.Button_Send_Money.Name = "Button_Send_Money";
            this.Button_Send_Money.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Button_Send_Money.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Button_Send_Money.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_Send_Money.selected = false;
            this.Button_Send_Money.Size = new System.Drawing.Size(303, 38);
            this.Button_Send_Money.TabIndex = 45;
            this.Button_Send_Money.Text = "Send Money";
            this.Button_Send_Money.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Send_Money.Textcolor = System.Drawing.Color.White;
            this.Button_Send_Money.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Send_Money.Click += new System.EventHandler(this.Button_Send_Money_Click);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Button_Send_Money);
            this.Controls.Add(this.textbox_Payment_Refrence);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dropdown_users);
            this.Controls.Add(this.Textbox_reciever_Account_Nummer);
            this.Controls.Add(this.textbox_Amount_dollar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_Amount_pennys);
            this.Controls.Add(this.panel_main);
            this.Name = "Transfer";
            this.Size = new System.Drawing.Size(853, 422);
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_balans_transfer;
        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.Label label_accountnummer;
        private Bunifu.Framework.UI.BunifuMetroTextbox textbox_Amount_pennys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox textbox_Amount_dollar;
        private Bunifu.Framework.UI.BunifuMetroTextbox Textbox_reciever_Account_Nummer;
        private Bunifu.Framework.UI.BunifuDropdown Dropdown_users;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox textbox_Payment_Refrence;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuImageButton button_back;
        private Bunifu.Framework.UI.BunifuFlatButton Button_Send_Money;
    }
}
