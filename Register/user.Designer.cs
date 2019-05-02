namespace Register
{
    partial class user
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
            this.btn_close = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.AutoSize = true;
            this.btn_close.BackColor = System.Drawing.Color.Black;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_close.Location = new System.Drawing.Point(601, 9);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(18, 19);
            this.btn_close.TabIndex = 58;
            this.btn_close.Text = "x";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // BunifuCustomLabel4
            // 
            this.BunifuCustomLabel4.AutoSize = true;
            this.BunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.BunifuCustomLabel4.Location = new System.Drawing.Point(212, 145);
            this.BunifuCustomLabel4.Name = "BunifuCustomLabel4";
            this.BunifuCustomLabel4.Size = new System.Drawing.Size(181, 22);
            this.BunifuCustomLabel4.TabIndex = 59;
            this.BunifuCustomLabel4.Text = "Selamat Datang !!!";
            this.BunifuCustomLabel4.Click += new System.EventHandler(this.BunifuCustomLabel4_Click);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 323);
            this.Controls.Add(this.BunifuCustomLabel4);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Bunifu.Framework.UI.BunifuCustomLabel btn_close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        internal Bunifu.Framework.UI.BunifuCustomLabel BunifuCustomLabel4;
    }
}