namespace MsgZap {
    partial class FrmMsg {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMsg));
            this.Rtxt_titulo = new System.Windows.Forms.RichTextBox();
            this.Rtxt_msg = new System.Windows.Forms.RichTextBox();
            this.Rtxt_infos = new System.Windows.Forms.RichTextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_padrao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_url_campanha = new System.Windows.Forms.TextBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rtxt_titulo
            // 
            this.Rtxt_titulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtxt_titulo.Location = new System.Drawing.Point(12, 33);
            this.Rtxt_titulo.Name = "Rtxt_titulo";
            this.Rtxt_titulo.Size = new System.Drawing.Size(392, 40);
            this.Rtxt_titulo.TabIndex = 0;
            this.Rtxt_titulo.Text = "";
            // 
            // Rtxt_msg
            // 
            this.Rtxt_msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtxt_msg.Location = new System.Drawing.Point(12, 99);
            this.Rtxt_msg.Name = "Rtxt_msg";
            this.Rtxt_msg.Size = new System.Drawing.Size(392, 179);
            this.Rtxt_msg.TabIndex = 1;
            this.Rtxt_msg.Text = "";
            // 
            // Rtxt_infos
            // 
            this.Rtxt_infos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtxt_infos.Location = new System.Drawing.Point(12, 305);
            this.Rtxt_infos.Name = "Rtxt_infos";
            this.Rtxt_infos.Size = new System.Drawing.Size(392, 89);
            this.Rtxt_infos.TabIndex = 2;
            this.Rtxt_infos.Text = "";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(329, 415);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 3;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(12, 14);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(46, 13);
            this.lbl_titulo.TabIndex = 4;
            this.lbl_titulo.Text = "TITULO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "MENSAGEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "INFORMAÇÕES FINAIS";
            // 
            // btn_padrao
            // 
            this.btn_padrao.Enabled = false;
            this.btn_padrao.Location = new System.Drawing.Point(248, 415);
            this.btn_padrao.Name = "btn_padrao";
            this.btn_padrao.Size = new System.Drawing.Size(75, 23);
            this.btn_padrao.TabIndex = 8;
            this.btn_padrao.Text = "Padrão";
            this.btn_padrao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_url_campanha);
            this.groupBox1.Location = new System.Drawing.Point(425, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 367);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PARÂMETROS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 212);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PARÂMETROS DA MENSAGEM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "COMPRIMENTO ALEATORIO = {comprimento}";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "MSG PADRÃO HI = {hi}";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "MSG PADRÃO HIX = {hix}";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "NOME ALUNO = {nome}";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "URL CAMPANHA = {campanha}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "URL CAMPANHA";
            // 
            // txt_url_campanha
            // 
            this.txt_url_campanha.Location = new System.Drawing.Point(22, 49);
            this.txt_url_campanha.Name = "txt_url_campanha";
            this.txt_url_campanha.Size = new System.Drawing.Size(251, 20);
            this.txt_url_campanha.TabIndex = 0;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(12, 415);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 10;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(282, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "COMPRIMENTO ALEATORIO PLUS = {comprimentoplus}";
            // 
            // FrmMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_padrao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rtxt_infos);
            this.Controls.Add(this.Rtxt_msg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.Rtxt_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "FrmMsg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensagem Personalizada";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Rtxt_titulo;
        private System.Windows.Forms.RichTextBox Rtxt_msg;
        private System.Windows.Forms.RichTextBox Rtxt_infos;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_padrao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_url_campanha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label10;
    }
}