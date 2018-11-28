namespace MsgZap {
    partial class FrmEmail {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmail));
            this.btn_testar = new System.Windows.Forms.Button();
            this.lbl_falhas = new System.Windows.Forms.Label();
            this.lbl_enviados = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.cb_testar = new System.Windows.Forms.CheckBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.cb_filtros = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.dtp_inicial = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_img = new System.Windows.Forms.TextBox();
            this.cbb_destinatario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_unidade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.Rtxt_titulo = new System.Windows.Forms.RichTextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DGV_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_campanha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_testar
            // 
            this.btn_testar.FlatAppearance.BorderSize = 0;
            this.btn_testar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn_testar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_testar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_testar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_testar.Location = new System.Drawing.Point(90, 462);
            this.btn_testar.Name = "btn_testar";
            this.btn_testar.Size = new System.Drawing.Size(80, 40);
            this.btn_testar.TabIndex = 54;
            this.btn_testar.Text = "Testar";
            this.btn_testar.UseVisualStyleBackColor = true;
            this.btn_testar.Click += new System.EventHandler(this.btn_testar_Click);
            // 
            // lbl_falhas
            // 
            this.lbl_falhas.AutoSize = true;
            this.lbl_falhas.Location = new System.Drawing.Point(304, 26);
            this.lbl_falhas.Name = "lbl_falhas";
            this.lbl_falhas.Size = new System.Drawing.Size(51, 13);
            this.lbl_falhas.TabIndex = 28;
            this.lbl_falhas.Text = "FALHAS:";
            // 
            // lbl_enviados
            // 
            this.lbl_enviados.AutoSize = true;
            this.lbl_enviados.Location = new System.Drawing.Point(161, 26);
            this.lbl_enviados.Name = "lbl_enviados";
            this.lbl_enviados.Size = new System.Drawing.Size(65, 13);
            this.lbl_enviados.TabIndex = 27;
            this.lbl_enviados.Text = "ENVIADOS:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_falhas);
            this.groupBox2.Controls.Add(this.lbl_enviados);
            this.groupBox2.Controls.Add(this.lbl_total);
            this.groupBox2.Location = new System.Drawing.Point(372, 437);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 65);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RESULTADOS";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(20, 26);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(45, 13);
            this.lbl_total.TabIndex = 26;
            this.lbl_total.Text = "TOTAL:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(180, 462);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(80, 40);
            this.btn_cancelar.TabIndex = 52;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // cb_testar
            // 
            this.cb_testar.AutoSize = true;
            this.cb_testar.Location = new System.Drawing.Point(785, 443);
            this.cb_testar.Name = "cb_testar";
            this.cb_testar.Size = new System.Drawing.Size(71, 17);
            this.cb_testar.TabIndex = 51;
            this.cb_testar.Text = "Testando";
            this.cb_testar.UseVisualStyleBackColor = true;
            this.cb_testar.Visible = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn_voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Location = new System.Drawing.Point(1, 462);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(80, 40);
            this.btn_voltar.TabIndex = 50;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // cb_filtros
            // 
            this.cb_filtros.AutoSize = true;
            this.cb_filtros.Location = new System.Drawing.Point(6, 75);
            this.cb_filtros.Name = "cb_filtros";
            this.cb_filtros.Size = new System.Drawing.Size(104, 17);
            this.cb_filtros.TabIndex = 36;
            this.cb_filtros.Text = "USAR FILTROS";
            this.cb_filtros.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "DATA FINAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "DATA INICIAL";
            // 
            // dtp_final
            // 
            this.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_final.Location = new System.Drawing.Point(100, 39);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(88, 20);
            this.dtp_final.TabIndex = 33;
            // 
            // dtp_inicial
            // 
            this.dtp_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicial.Location = new System.Drawing.Point(6, 39);
            this.dtp_inicial.Name = "dtp_inicial";
            this.dtp_inicial.Size = new System.Drawing.Size(88, 20);
            this.dtp_inicial.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_filtros);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtp_final);
            this.groupBox1.Controls.Add(this.dtp_inicial);
            this.groupBox1.Location = new System.Drawing.Point(156, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 133);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRO POR DATAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "URL IMG";
            // 
            // txt_img
            // 
            this.txt_img.Location = new System.Drawing.Point(26, 151);
            this.txt_img.Name = "txt_img";
            this.txt_img.Size = new System.Drawing.Size(281, 20);
            this.txt_img.TabIndex = 47;
            // 
            // cbb_destinatario
            // 
            this.cbb_destinatario.FormattingEnabled = true;
            this.cbb_destinatario.Items.AddRange(new object[] {
            "ALUNO",
            "VISITANTE"});
            this.cbb_destinatario.Location = new System.Drawing.Point(29, 29);
            this.cbb_destinatario.Name = "cbb_destinatario";
            this.cbb_destinatario.Size = new System.Drawing.Size(121, 21);
            this.cbb_destinatario.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "DESTINATARIO";
            // 
            // cbb_unidade
            // 
            this.cbb_unidade.FormattingEnabled = true;
            this.cbb_unidade.Items.AddRange(new object[] {
            "1- HI TAMARINEIRA",
            "5- HI ESPINHEIRO",
            "6- HI BOA VIAGEM 2",
            "10- HI BOA VIAGEM 3",
            "31- HI ENCRUZILHADA",
            "8- HIX ESPINHEIRO",
            "9- HIX PIEDADE",
            "11- HIX OLINDA",
            "12- HIX SETÚBAL",
            "13- HIX LAGOA",
            "19- HIX IPSEP",
            "24- HIX ARRUDA"});
            this.cbb_unidade.Location = new System.Drawing.Point(29, 76);
            this.cbb_unidade.Name = "cbb_unidade";
            this.cbb_unidade.Size = new System.Drawing.Size(121, 21);
            this.cbb_unidade.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "UNIDADE";
            // 
            // btn_enviar
            // 
            this.btn_enviar.FlatAppearance.BorderSize = 0;
            this.btn_enviar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn_enviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_enviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviar.Location = new System.Drawing.Point(270, 462);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(80, 40);
            this.btn_enviar.TabIndex = 38;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // Rtxt_titulo
            // 
            this.Rtxt_titulo.BackColor = System.Drawing.SystemColors.Window;
            this.Rtxt_titulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtxt_titulo.Location = new System.Drawing.Point(26, 236);
            this.Rtxt_titulo.Name = "Rtxt_titulo";
            this.Rtxt_titulo.Size = new System.Drawing.Size(281, 30);
            this.Rtxt_titulo.TabIndex = 37;
            this.Rtxt_titulo.Text = "";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_nome,
            this.DGV_status,
            this.DGV_email});
            this.dataGridView2.Location = new System.Drawing.Point(372, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(374, 426);
            this.dataGridView2.TabIndex = 46;
            // 
            // DGV_nome
            // 
            this.DGV_nome.HeaderText = "Nome";
            this.DGV_nome.Name = "DGV_nome";
            this.DGV_nome.ReadOnly = true;
            this.DGV_nome.Width = 125;
            // 
            // DGV_status
            // 
            this.DGV_status.HeaderText = "Status";
            this.DGV_status.Name = "DGV_status";
            this.DGV_status.ReadOnly = true;
            // 
            // DGV_email
            // 
            this.DGV_email.HeaderText = "Email";
            this.DGV_email.Name = "DGV_email";
            this.DGV_email.ReadOnly = true;
            this.DGV_email.Width = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "URL CAMPANHA";
            // 
            // txt_campanha
            // 
            this.txt_campanha.Location = new System.Drawing.Point(26, 190);
            this.txt_campanha.Name = "txt_campanha";
            this.txt_campanha.Size = new System.Drawing.Size(281, 20);
            this.txt_campanha.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "TITULO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(265, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 40);
            this.panel1.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(175, 462);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 40);
            this.panel2.TabIndex = 60;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(85, 462);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 40);
            this.panel3.TabIndex = 61;
            // 
            // FrmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(769, 516);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_campanha);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.cb_testar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_img);
            this.Controls.Add(this.cbb_destinatario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbb_unidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Rtxt_titulo);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.btn_testar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de Emails";
            this.Load += new System.EventHandler(this.FrmEmail_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_testar;
        private System.Windows.Forms.Label lbl_falhas;
        private System.Windows.Forms.Label lbl_enviados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.CheckBox cb_testar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.CheckBox cb_filtros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.DateTimePicker dtp_inicial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_img;
        private System.Windows.Forms.ComboBox cbb_destinatario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_unidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.RichTextBox Rtxt_titulo;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_campanha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_email;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}