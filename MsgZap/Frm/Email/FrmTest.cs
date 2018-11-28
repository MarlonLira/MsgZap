using System;
using System.Windows.Forms;

namespace MsgZap {
    public partial class FrmTest : Form 
    {
        FrmEmail Email;
        public FrmTest(FrmEmail Frm) 
        {
            InitializeComponent();
            Email = Frm;
        }

        private void btn_salvar_Click(object sender, EventArgs e) 
        {
            this.Hide();
            Email.Test(txt_nome_destinatario.Text, txt_email_destinatario.Text);
            MessageBox.Show("UM EMAIL DE TESTE SERÁ ENVIADO PARA: " + txt_email_destinatario.Text.ToUpper());
        }

        private void btn_voltar_Click(object sender, EventArgs e) 
        {
            this.Hide();
        }
    }
}
