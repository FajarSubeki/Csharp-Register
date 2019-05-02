namespace Register
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.masuk = new Bunifu.Framework.UI.BunifuThinButton2();
            this.nis = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_close = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // password
            // 
            this.password.BorderColorFocused = System.Drawing.Color.Black;
            this.password.BorderColorIdle = System.Drawing.Color.Silver;
            this.password.BorderColorMouseHover = System.Drawing.SystemColors.ControlLightLight;
            this.password.BorderThickness = 2;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.isPassword = true;
            this.password.Location = new System.Drawing.Point(26, 238);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(298, 37);
            this.password.TabIndex = 10;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // masuk
            // 
            this.masuk.ActiveBorderThickness = 1;
            this.masuk.ActiveCornerRadius = 1;
            this.masuk.ActiveFillColor = System.Drawing.Color.Gray;
            this.masuk.ActiveForecolor = System.Drawing.Color.Gray;
            this.masuk.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.masuk.BackColor = System.Drawing.Color.White;
            this.masuk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("masuk.BackgroundImage")));
            this.masuk.ButtonText = "Masuk";
            this.masuk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.masuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masuk.ForeColor = System.Drawing.Color.White;
            this.masuk.IdleBorderThickness = 1;
            this.masuk.IdleCornerRadius = 1;
            this.masuk.IdleFillColor = System.Drawing.Color.Black;
            this.masuk.IdleForecolor = System.Drawing.Color.White;
            this.masuk.IdleLineColor = System.Drawing.Color.White;
            this.masuk.Location = new System.Drawing.Point(26, 332);
            this.masuk.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.masuk.Name = "masuk";
            this.masuk.Size = new System.Drawing.Size(298, 56);
            this.masuk.TabIndex = 11;
            this.masuk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.masuk.Click += new System.EventHandler(this.masuk_Click);
            // 
            // nis
            // 
            this.nis.AccessibleDescription = "";
            this.nis.BorderColorFocused = System.Drawing.Color.Black;
            this.nis.BorderColorIdle = System.Drawing.Color.Silver;
            this.nis.BorderColorMouseHover = System.Drawing.SystemColors.ControlLightLight;
            this.nis.BorderThickness = 2;
            this.nis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nis.ForeColor = System.Drawing.Color.Black;
            this.nis.isPassword = false;
            this.nis.Location = new System.Drawing.Point(26, 148);
            this.nis.Margin = new System.Windows.Forms.Padding(4);
            this.nis.Name = "nis";
            this.nis.Size = new System.Drawing.Size(298, 37);
            this.nis.TabIndex = 9;
            this.nis.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.angka);
            // 
            // BunifuCustomLabel5
            // 
            this.BunifuCustomLabel5.AutoSize = true;
            this.BunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuCustomLabel5.ForeColor = System.Drawing.Color.Black;
            this.BunifuCustomLabel5.Location = new System.Drawing.Point(23, 217);
            this.BunifuCustomLabel5.Name = "BunifuCustomLabel5";
            this.BunifuCustomLabel5.Size = new System.Drawing.Size(68, 16);
            this.BunifuCustomLabel5.TabIndex = 8;
            this.BunifuCustomLabel5.Text = "Password";
            // 
            // BunifuCustomLabel4
            // 
            this.BunifuCustomLabel4.AutoSize = true;
            this.BunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.BunifuCustomLabel4.Location = new System.Drawing.Point(23, 127);
            this.BunifuCustomLabel4.Name = "BunifuCustomLabel4";
            this.BunifuCustomLabel4.Size = new System.Drawing.Size(28, 16);
            this.BunifuCustomLabel4.TabIndex = 7;
            this.BunifuCustomLabel4.Text = "Nis";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(133, 51);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(80, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Login";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(23, 301);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(62, 16);
            this.bunifuCustomLabel3.TabIndex = 14;
            this.bunifuCustomLabel3.Text = "Register ";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // btn_close
            // 
            this.btn_close.AutoSize = true;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_close.Location = new System.Drawing.Point(324, 9);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(17, 20);
            this.btn_close.TabIndex = 57;
            this.btn_close.Text = "x";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 1;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Tutup";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 1;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(26, 388);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(298, 48);
            this.bunifuThinButton21.TabIndex = 60;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 455);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.masuk);
            this.Controls.Add(this.nis);
            this.Controls.Add(this.BunifuCustomLabel5);
            this.Controls.Add(this.BunifuCustomLabel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        internal Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        internal Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        internal Bunifu.Framework.UI.BunifuMetroTextbox password;
        internal Bunifu.Framework.UI.BunifuThinButton2 masuk;
        internal Bunifu.Framework.UI.BunifuMetroTextbox nis;
        internal Bunifu.Framework.UI.BunifuCustomLabel BunifuCustomLabel5;
        internal Bunifu.Framework.UI.BunifuCustomLabel BunifuCustomLabel4;
        internal Bunifu.Framework.UI.BunifuCustomLabel btn_close;
        internal Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;

    }
}

