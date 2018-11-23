namespace MsgZap {
    partial class FrmBase {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.Rtxt_Texto = new System.Windows.Forms.RichTextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_unidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_destinatario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_remetente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DGV_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_img = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_filtros = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.dtp_inicial = new System.Windows.Forms.DateTimePicker();
            this.btn_testar = new System.Windows.Forms.Button();
            this.cb_testar = new System.Windows.Forms.CheckBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_falhas = new System.Windows.Forms.Label();
            this.lbl_enviados = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_personalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rtxt_Texto
            // 
            this.Rtxt_Texto.BackColor = System.Drawing.SystemColors.Window;
            this.Rtxt_Texto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtxt_Texto.Location = new System.Drawing.Point(31, 250);
            this.Rtxt_Texto.Name = "Rtxt_Texto";
            this.Rtxt_Texto.Size = new System.Drawing.Size(326, 254);
            this.Rtxt_Texto.TabIndex = 1;
            this.Rtxt_Texto.Text = "";
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(282, 221);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(75, 23);
            this.btn_enviar.TabIndex = 2;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "UNIDADE";
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
            this.cbb_unidade.Location = new System.Drawing.Point(34, 129);
            this.cbb_unidade.Name = "cbb_unidade";
            this.cbb_unidade.Size = new System.Drawing.Size(121, 21);
            this.cbb_unidade.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "DESTINATARIO";
            // 
            // cbb_destinatario
            // 
            this.cbb_destinatario.FormattingEnabled = true;
            this.cbb_destinatario.Items.AddRange(new object[] {
            "ALUNO",
            "VISITANTE"});
            this.cbb_destinatario.Location = new System.Drawing.Point(34, 82);
            this.cbb_destinatario.Name = "cbb_destinatario";
            this.cbb_destinatario.Size = new System.Drawing.Size(121, 21);
            this.cbb_destinatario.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(34, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "REMETENTE";
            // 
            // txt_remetente
            // 
            this.txt_remetente.Enabled = false;
            this.txt_remetente.Location = new System.Drawing.Point(34, 36);
            this.txt_remetente.Name = "txt_remetente";
            this.txt_remetente.Size = new System.Drawing.Size(121, 20);
            this.txt_remetente.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(114, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ex: 8188889999";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_nome,
            this.DGV_telefone,
            this.DGV_status});
            this.dataGridView2.Location = new System.Drawing.Point(377, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(374, 426);
            this.dataGridView2.TabIndex = 22;
            // 
            // DGV_nome
            // 
            this.DGV_nome.HeaderText = "Nome";
            this.DGV_nome.Name = "DGV_nome";
            this.DGV_nome.ReadOnly = true;
            this.DGV_nome.Width = 125;
            // 
            // DGV_telefone
            // 
            this.DGV_telefone.HeaderText = "Telefone";
            this.DGV_telefone.Name = "DGV_telefone";
            this.DGV_telefone.ReadOnly = true;
            this.DGV_telefone.Width = 105;
            // 
            // DGV_status
            // 
            this.DGV_status.HeaderText = "Status";
            this.DGV_status.Name = "DGV_status";
            this.DGV_status.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(34, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "URL IMG";
            // 
            // txt_img
            // 
            this.txt_img.Enabled = false;
            this.txt_img.Location = new System.Drawing.Point(34, 175);
            this.txt_img.Name = "txt_img";
            this.txt_img.Size = new System.Drawing.Size(281, 20);
            this.txt_img.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_filtros);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtp_final);
            this.groupBox1.Controls.Add(this.dtp_inicial);
            this.groupBox1.Location = new System.Drawing.Point(161, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 133);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRO POR DATAS";
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
            // btn_testar
            // 
            this.btn_testar.Location = new System.Drawing.Point(31, 221);
            this.btn_testar.Name = "btn_testar";
            this.btn_testar.Size = new System.Drawing.Size(75, 23);
            this.btn_testar.TabIndex = 32;
            this.btn_testar.Text = "Testar";
            this.btn_testar.UseVisualStyleBackColor = true;
            this.btn_testar.Click += new System.EventHandler(this.btn_testar_Click);
            // 
            // cb_testar
            // 
            this.cb_testar.AutoSize = true;
            this.cb_testar.Location = new System.Drawing.Point(790, 450);
            this.cb_testar.Name = "cb_testar";
            this.cb_testar.Size = new System.Drawing.Size(71, 17);
            this.cb_testar.TabIndex = 33;
            this.cb_testar.Text = "Testando";
            this.cb_testar.UseVisualStyleBackColor = true;
            this.cb_testar.Visible = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(201, 221);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 34;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_falhas);
            this.groupBox2.Controls.Add(this.lbl_enviados);
            this.groupBox2.Controls.Add(this.lbl_total);
            this.groupBox2.Location = new System.Drawing.Point(377, 444);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 65);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RESULTADOS";
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
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(20, 26);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(45, 13);
            this.lbl_total.TabIndex = 26;
            this.lbl_total.Text = "TOTAL:";
            // 
            // btn_personalizar
            // 
            this.btn_personalizar.Location = new System.Drawing.Point(117, 221);
            this.btn_personalizar.Name = "btn_personalizar";
            this.btn_personalizar.Size = new System.Drawing.Size(75, 23);
            this.btn_personalizar.TabIndex = 36;
            this.btn_personalizar.Text = "Personalizar";
            this.btn_personalizar.UseVisualStyleBackColor = true;
            this.btn_personalizar.Click += new System.EventHandler(this.btn_personalizar_Click);
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(769, 516);
            this.Controls.Add(this.btn_personalizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.cb_testar);
            this.Controls.Add(this.btn_testar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_img);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_remetente);
            this.Controls.Add(this.cbb_destinatario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbb_unidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.Rtxt_Texto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MsgZap";
            this.Load += new System.EventHandler(this.FrmBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Rtxt_Texto;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_unidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_destinatario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_remetente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_img;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.DateTimePicker dtp_inicial;
        private System.Windows.Forms.CheckBox cb_filtros;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_status;
        private System.Windows.Forms.Button btn_testar;
        private System.Windows.Forms.CheckBox cb_testar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_falhas;
        private System.Windows.Forms.Label lbl_enviados;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_personalizar;
    }
}

