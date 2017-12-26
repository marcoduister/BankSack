namespace BankSack
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.panel_deposit_dollar = new System.Windows.Forms.Panel();
            this.button_back = new Bunifu.Framework.UI.BunifuImageButton();
            this.button_agreed = new Bunifu.Framework.UI.BunifuTileButton();
            this.textbox_amount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel_deposit_dollar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_deposit_dollar
            // 
            this.panel_deposit_dollar.Controls.Add(this.button_back);
            this.panel_deposit_dollar.Controls.Add(this.button_agreed);
            this.panel_deposit_dollar.Controls.Add(this.textbox_amount);
            this.panel_deposit_dollar.Location = new System.Drawing.Point(3, 3);
            this.panel_deposit_dollar.Name = "panel_deposit_dollar";
            this.panel_deposit_dollar.Size = new System.Drawing.Size(853, 422);
            this.panel_deposit_dollar.TabIndex = 61;
            this.panel_deposit_dollar.Visible = false;
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
            this.button_back.TabIndex = 62;
            this.button_back.TabStop = false;
            this.button_back.Zoom = 10;
            this.button_back.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // button_agreed
            // 
            this.button_agreed.BackColor = System.Drawing.Color.SeaGreen;
            this.button_agreed.color = System.Drawing.Color.SeaGreen;
            this.button_agreed.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.button_agreed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_agreed.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agreed.ForeColor = System.Drawing.Color.White;
            this.button_agreed.Image = null;
            this.button_agreed.ImagePosition = 31;
            this.button_agreed.ImageZoom = 50;
            this.button_agreed.LabelPosition = 68;
            this.button_agreed.LabelText = "Agreed";
            this.button_agreed.Location = new System.Drawing.Point(485, 167);
            this.button_agreed.Margin = new System.Windows.Forms.Padding(5);
            this.button_agreed.Name = "button_agreed";
            this.button_agreed.Size = new System.Drawing.Size(237, 100);
            this.button_agreed.TabIndex = 59;
            this.button_agreed.Click += new System.EventHandler(this.button_agreed_Click);
            // 
            // textbox_amount
            // 
            this.textbox_amount.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.textbox_amount.BorderColorIdle = System.Drawing.Color.Silver;
            this.textbox_amount.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.textbox_amount.BorderThickness = 15;
            this.textbox_amount.Cursor = System.Windows.Forms.Cursors.Default;
            this.textbox_amount.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_amount.ForeColor = System.Drawing.Color.Silver;
            this.textbox_amount.isPassword = false;
            this.textbox_amount.Location = new System.Drawing.Point(87, 135);
            this.textbox_amount.Margin = new System.Windows.Forms.Padding(18);
            this.textbox_amount.Name = "textbox_amount";
            this.textbox_amount.Size = new System.Drawing.Size(375, 150);
            this.textbox_amount.TabIndex = 9;
            this.textbox_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.panel_deposit_dollar);
            this.Name = "Deposit";
            this.Size = new System.Drawing.Size(853, 422);
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.panel_deposit_dollar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_deposit_dollar;
        private Bunifu.Framework.UI.BunifuTileButton button_agreed;
        private Bunifu.Framework.UI.BunifuMetroTextbox textbox_amount;
        private Bunifu.Framework.UI.BunifuImageButton button_back;
    }
}
