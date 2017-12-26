namespace BankSack
{
    partial class main_frame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_frame));
            this.button_Deposit = new Bunifu.Framework.UI.BunifuTileButton();
            this.button_Info = new Bunifu.Framework.UI.BunifuTileButton();
            this.button_Transfer = new Bunifu.Framework.UI.BunifuTileButton();
            this.button_Withdraw = new Bunifu.Framework.UI.BunifuTileButton();
            this.label_balans_main = new System.Windows.Forms.Label();
            this.button_back = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.button_back)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Deposit
            // 
            this.button_Deposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button_Deposit.color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button_Deposit.colorActive = System.Drawing.Color.SeaGreen;
            this.button_Deposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Deposit.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.button_Deposit.ForeColor = System.Drawing.Color.White;
            this.button_Deposit.Image = ((System.Drawing.Image)(resources.GetObject("button_Deposit.Image")));
            this.button_Deposit.ImagePosition = 20;
            this.button_Deposit.ImageZoom = 50;
            this.button_Deposit.LabelPosition = 41;
            this.button_Deposit.LabelText = "Deposit";
            this.button_Deposit.Location = new System.Drawing.Point(144, 124);
            this.button_Deposit.Margin = new System.Windows.Forms.Padding(6);
            this.button_Deposit.Name = "button_Deposit";
            this.button_Deposit.Size = new System.Drawing.Size(128, 129);
            this.button_Deposit.TabIndex = 20;
            this.button_Deposit.Click += new System.EventHandler(this.Button_Deposit_Click);
            // 
            // button_Info
            // 
            this.button_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button_Info.color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button_Info.colorActive = System.Drawing.Color.SeaGreen;
            this.button_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Info.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.button_Info.ForeColor = System.Drawing.Color.White;
            this.button_Info.Image = ((System.Drawing.Image)(resources.GetObject("button_Info.Image")));
            this.button_Info.ImagePosition = 20;
            this.button_Info.ImageZoom = 50;
            this.button_Info.LabelPosition = 41;
            this.button_Info.LabelText = "Info";
            this.button_Info.Location = new System.Drawing.Point(564, 124);
            this.button_Info.Margin = new System.Windows.Forms.Padding(6);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(128, 129);
            this.button_Info.TabIndex = 21;
            this.button_Info.Click += new System.EventHandler(this.button_Info_Click);
            // 
            // button_Transfer
            // 
            this.button_Transfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button_Transfer.color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button_Transfer.colorActive = System.Drawing.Color.SeaGreen;
            this.button_Transfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Transfer.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.button_Transfer.ForeColor = System.Drawing.Color.White;
            this.button_Transfer.Image = ((System.Drawing.Image)(resources.GetObject("button_Transfer.Image")));
            this.button_Transfer.ImagePosition = 20;
            this.button_Transfer.ImageZoom = 50;
            this.button_Transfer.LabelPosition = 41;
            this.button_Transfer.LabelText = "Transfer";
            this.button_Transfer.Location = new System.Drawing.Point(424, 124);
            this.button_Transfer.Margin = new System.Windows.Forms.Padding(6);
            this.button_Transfer.Name = "button_Transfer";
            this.button_Transfer.Size = new System.Drawing.Size(128, 129);
            this.button_Transfer.TabIndex = 22;
            this.button_Transfer.Click += new System.EventHandler(this.button_Transfer_Click);
            // 
            // button_Withdraw
            // 
            this.button_Withdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button_Withdraw.color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button_Withdraw.colorActive = System.Drawing.Color.SeaGreen;
            this.button_Withdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Withdraw.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.button_Withdraw.ForeColor = System.Drawing.Color.White;
            this.button_Withdraw.Image = ((System.Drawing.Image)(resources.GetObject("button_Withdraw.Image")));
            this.button_Withdraw.ImagePosition = 20;
            this.button_Withdraw.ImageZoom = 50;
            this.button_Withdraw.LabelPosition = 41;
            this.button_Withdraw.LabelText = "Withdraw";
            this.button_Withdraw.Location = new System.Drawing.Point(284, 124);
            this.button_Withdraw.Margin = new System.Windows.Forms.Padding(6);
            this.button_Withdraw.Name = "button_Withdraw";
            this.button_Withdraw.Size = new System.Drawing.Size(128, 129);
            this.button_Withdraw.TabIndex = 23;
            this.button_Withdraw.Click += new System.EventHandler(this.button_Withdraw_Click);
            // 
            // label_balans_main
            // 
            this.label_balans_main.AutoSize = true;
            this.label_balans_main.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_balans_main.ForeColor = System.Drawing.Color.White;
            this.label_balans_main.Location = new System.Drawing.Point(17, 17);
            this.label_balans_main.Name = "label_balans_main";
            this.label_balans_main.Size = new System.Drawing.Size(79, 30);
            this.label_balans_main.TabIndex = 25;
            this.label_balans_main.Text = "€ 0,00";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.Image = ((System.Drawing.Image)(resources.GetObject("button_back.Image")));
            this.button_back.ImageActive = null;
            this.button_back.Location = new System.Drawing.Point(776, 319);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(71, 71);
            this.button_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_back.TabIndex = 64;
            this.button_back.TabStop = false;
            this.button_back.Zoom = 10;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(781, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "Exit";
            // 
            // main_frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label_balans_main);
            this.Controls.Add(this.button_Withdraw);
            this.Controls.Add(this.button_Transfer);
            this.Controls.Add(this.button_Info);
            this.Controls.Add(this.button_Deposit);
            this.Name = "main_frame";
            this.Size = new System.Drawing.Size(850, 423);
            this.Load += new System.EventHandler(this.main_frame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.button_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton button_Deposit;
        private Bunifu.Framework.UI.BunifuTileButton button_Info;
        private Bunifu.Framework.UI.BunifuTileButton button_Transfer;
        private Bunifu.Framework.UI.BunifuTileButton button_Withdraw;
        private System.Windows.Forms.Label label_balans_main;
        private Bunifu.Framework.UI.BunifuImageButton button_back;
        private System.Windows.Forms.Label label1;
    }
}
