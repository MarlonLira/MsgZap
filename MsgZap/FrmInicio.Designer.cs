namespace MsgZap
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.Rtxt_texto = new System.Windows.Forms.RichTextBox();
            this.txt_remetente = new System.Windows.Forms.TextBox();
            this.txt_destinatario = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.lbl_remetente = new System.Windows.Forms.Label();
            this.lbl_destinatario = new System.Windows.Forms.Label();
            this.txt_token = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DGV_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Rtxt_texto
            // 
            resources.ApplyResources(this.Rtxt_texto, "Rtxt_texto");
            this.Rtxt_texto.Name = "Rtxt_texto";
            // 
            // txt_remetente
            // 
            resources.ApplyResources(this.txt_remetente, "txt_remetente");
            this.txt_remetente.Name = "txt_remetente";
            // 
            // txt_destinatario
            // 
            resources.ApplyResources(this.txt_destinatario, "txt_destinatario");
            this.txt_destinatario.Name = "txt_destinatario";
            // 
            // btn_enviar
            // 
            resources.ApplyResources(this.btn_enviar, "btn_enviar");
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // lbl_remetente
            // 
            resources.ApplyResources(this.lbl_remetente, "lbl_remetente");
            this.lbl_remetente.Name = "lbl_remetente";
            // 
            // lbl_destinatario
            // 
            resources.ApplyResources(this.lbl_destinatario, "lbl_destinatario");
            this.lbl_destinatario.Name = "lbl_destinatario";
            // 
            // txt_token
            // 
            resources.ApplyResources(this.txt_token, "txt_token");
            this.txt_token.Name = "txt_token";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_nome,
            this.DGV_telefone,
            this.DGV_status});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            // 
            // DGV_nome
            // 
            resources.ApplyResources(this.DGV_nome, "DGV_nome");
            this.DGV_nome.Name = "DGV_nome";
            this.DGV_nome.ReadOnly = true;
            // 
            // DGV_telefone
            // 
            resources.ApplyResources(this.DGV_telefone, "DGV_telefone");
            this.DGV_telefone.Name = "DGV_telefone";
            this.DGV_telefone.ReadOnly = true;
            // 
            // DGV_status
            // 
            resources.ApplyResources(this.DGV_status, "DGV_status");
            this.DGV_status.Name = "DGV_status";
            this.DGV_status.ReadOnly = true;
            // 
            // FrmInicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_token);
            this.Controls.Add(this.lbl_destinatario);
            this.Controls.Add(this.lbl_remetente);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_destinatario);
            this.Controls.Add(this.txt_remetente);
            this.Controls.Add(this.Rtxt_texto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmInicio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Rtxt_texto;
        private System.Windows.Forms.TextBox txt_remetente;
        private System.Windows.Forms.TextBox txt_destinatario;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label lbl_remetente;
        private System.Windows.Forms.Label lbl_destinatario;
        private System.Windows.Forms.TextBox txt_token;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_status;
    }
}

