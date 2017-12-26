namespace BankSack.form
{
    partial class Main_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_menu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_upper = new System.Windows.Forms.Panel();
            this.button_minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.button_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_main = new System.Windows.Forms.Panel();
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
            // panel_upper
            // 
            this.panel_upper.Controls.Add(this.button_minimize);
            this.panel_upper.Controls.Add(this.button_Close);
            this.panel_upper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_upper.Location = new System.Drawing.Point(0, 0);
            this.panel_upper.Name = "panel_upper";
            this.panel_upper.Size = new System.Drawing.Size(853, 33);
            this.panel_upper.TabIndex = 6;
            this.panel_upper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // button_minimize
            // 
            this.button_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button_minimize.Image = ((System.Drawing.Image)(resources.GetObject("button_minimize.Image")));
            this.button_minimize.ImageActive = null;
            this.button_minimize.Location = new System.Drawing.Point(793, 0);
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
            this.button_Close.Location = new System.Drawing.Point(820, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Close.TabIndex = 7;
            this.button_Close.TabStop = false;
            this.button_Close.Zoom = 10;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // panel_main
            // 
            this.panel_main.Location = new System.Drawing.Point(0, 36);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(850, 423);
            this.panel_main.TabIndex = 7;
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(853, 455);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_upper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_menu";
            this.Load += new System.EventHandler(this.Main_menu_Load);
            this.panel_upper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel_upper;
        private Bunifu.Framework.UI.BunifuImageButton button_minimize;
        private Bunifu.Framework.UI.BunifuImageButton button_Close;
        public System.Windows.Forms.Panel panel_main;
    }
}