using System;
using System.Windows.Forms;

namespace MsgZap {
    public partial class FrmMsg : Form {

        FrmBase Inicio;
        
        public FrmMsg(FrmBase Frm) 
        {
            InitializeComponent();
            Inicio = Frm;
        }

        private String MsgReplace(String MsgAnt)
        {
            String Msg = "";

            Msg = MsgAnt.Replace("{campanha}", txt_url_campanha.Text);

            return Msg;
        }

        private void btn_voltar_Click(object sender, EventArgs e) 
        {
            this.Hide();
            Inicio.Show();
        }

        private void btn_salvar_Click(object sender, EventArgs e) 
        {
            Inicio.MsgPersonalizada(MsgReplace(Rtxt_titulo.Text), MsgReplace(Rtxt_msg.Text), MsgReplace(Rtxt_infos.Text));
            this.Hide();
            Inicio.Show();
        }
        
    }
}
