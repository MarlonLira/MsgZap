namespace MsgZap {
    partial class FrmHome {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mensagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_whats = new System.Windows.Forms.Button();
            this.btn_emails = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mensagensToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(395, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mensagensToolStripMenuItem
            // 
            this.mensagensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whatsAppToolStripMenuItem,
            this.emailToolStripMenuItem});
            this.mensagensToolStripMenuItem.Name = "mensagensToolStripMenuItem";
            this.mensagensToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.mensagensToolStripMenuItem.Text = "Mensagens";
            // 
            // whatsAppToolStripMenuItem
            // 
            this.whatsAppToolStripMenuItem.Name = "whatsAppToolStripMenuItem";
            this.whatsAppToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.whatsAppToolStripMenuItem.Text = "WhatsApp";
            this.whatsAppToolStripMenuItem.Click += new System.EventHandler(this.whatsAppToolStripMenuItem_Click);
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.emailToolStripMenuItem.Text = "Email";
            this.emailToolStripMenuItem.Click += new System.EventHandler(this.emailToolStripMenuItem_Click);
            // 
            // btn_whats
            // 
            this.btn_whats.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_whats.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn_whats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_whats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_whats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_whats.Location = new System.Drawing.Point(12, 38);
            this.btn_whats.Name = "btn_whats";
            this.btn_whats.Size = new System.Drawing.Size(180, 100);
            this.btn_whats.TabIndex = 1;
            this.btn_whats.Text = "ENVIAR WHATSAPP";
            this.btn_whats.UseVisualStyleBackColor = true;
            this.btn_whats.Click += new System.EventHandler(this.btn_whats_Click);
            // 
            // btn_emails
            // 
            this.btn_emails.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn_emails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_emails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_emails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emails.Location = new System.Drawing.Point(203, 38);
            this.btn_emails.Name = "btn_emails";
            this.btn_emails.Size = new System.Drawing.Size(180, 100);
            this.btn_emails.TabIndex = 2;
            this.btn_emails.Text = "ENVIAR EMAILS";
            this.btn_emails.UseVisualStyleBackColor = true;
            this.btn_emails.Click += new System.EventHandler(this.btn_emails_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(395, 153);
            this.Controls.Add(this.btn_emails);
            this.Controls.Add(this.btn_whats);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mensagensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatsAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.Button btn_whats;
        private System.Windows.Forms.Button btn_emails;
    }
}