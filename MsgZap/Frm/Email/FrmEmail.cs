using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using MsgZap.Model;
using MsgZap.Persistence;
using MsgZap.Helper;
using System.Threading.Tasks;

namespace MsgZap {
    public partial class FrmEmail : Form 
    {

        MailMessage Mail;
        FrmHome Inicio;
        EmailSendPST Send;
        DataTable Table;
        Connect Con;
        Hlp Hlp;

        //Variaveis de controle
        Boolean Parar;
        Int32 Enviados;
        Int32 Falhas;

        public FrmEmail(FrmHome Frm) 
        {
            InitializeComponent();

            Inicio = Frm;
            dtp_final.Text = DateTime.Now.ToShortDateString();
            Enviados = 0;
            Falhas = 0;
        }

        public String MsgFormat() 
        {

            String Msg = Send.CreateMsg;

            try 
            {
               String[] Nome = Send.Destinatario.Nome.Split(' ');

                Msg = Msg.Replace("{NOME}", Hlp.RandomTalk(Nome[0]));
                Msg = Msg.Replace("{URL_IMG}", Send.UrlImg);
                Msg = Msg.Replace("{URL_CAMPANHA}", Send.UrlCampanha);
                Msg = Msg.Replace("{RESPONDER_PARA}", Send.Remetente.Email);
                Msg = Msg.Replace("{TEXTO_ESPECIAL}", "");
                Msg = Msg.Replace("{TEXTO_LEGAL}", "");

            } catch (Exception e) 
            {
                MessageBox.Show(e.Message);
            }

            return Msg;
        }

        public void DisplayData(String Script) 
        {
            Con.OpenCon();
            Table = new DataTable();
            Con.OpenAdpter(Script);
            Con.Adapt.Fill(Table);
            Con.CloseCon();
        }

        public void Test(String Nome, String Email) 
        {
            Mail = new MailMessage();
            Send = new EmailSendPST();
            Send.Remetente = new Remetente();
            Send.Destinatario = new Destinatario();
            Con = new Connect();
            Hlp = new Hlp();

            if (String.IsNullOrEmpty(txt_img.Text) && String.IsNullOrEmpty(txt_campanha.Text)) 
            {
                Rtxt_titulo.Text = "CAMPANHA DE VERÃO HIX";
                txt_campanha.Text = "http://ofertas.yesfitacademia.com.br/";
                txt_img.Text = "https://i.imgur.com/6ifBI3c.jpg";
            }

            using (SmtpClient Smtp = new SmtpClient()) 
            {
                try 
                {
                    Armazenar();

                    //Config Servidor Email
                    Smtp.Host = Send.Host;
                    Smtp.Port = Send.Port;
                    Smtp.EnableSsl = true;
                    Smtp.UseDefaultCredentials = false;
                    Smtp.Credentials = new NetworkCredential(Send.From, Send.Pass);

                    //Config Destinatario
                    Send.Destinatario.Nome = Nome;
                    Send.Destinatario.Email = Email;
                    Send.Body = MsgFormat();

                    using (MailMessage Mail = new MailMessage()) 
                    {
                        //Armazenamento dos dados
                        Mail.From = new MailAddress(Send.From);
                        Mail.To.Add(new MailAddress(Send.Destinatario.Email));
                        Mail.Subject = Send.Subject;
                        Mail.IsBodyHtml = true;
                        Mail.Body = Send.Body;

                        Smtp.Send(Mail);

                        Enviados++;
                        lbl_enviados.Text = "ENVIADOS: " + Enviados.ToString();
                        lbl_total.Text = "TOTAL: " + (Enviados + Falhas).ToString();
                        dataGridView2.Rows.Add(Send.Destinatario.Nome, "ENVIADO", Send.Destinatario.Email);
                        
                    }
                } catch (Exception e) 
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        public void EnviarOperadores() 
        {
            String[] EmailOperador = {"marlon.lira@hiacademia.com.br", "marketing@hiacademia.com.br", "newtonvvf@hotmail.com"};
            String[] NameOperador = {"Marlon", "Carol","Newton"};

            try
            {
                for (int x = 0; x <= 2; x++) 
                {
                    Test(NameOperador[x], EmailOperador[x]);
                }

            } catch (Exception e) 
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Armazenar() 
        {
            //Send = new EmailSendPST();
            Send.Remetente = new Remetente();

            // Dados Remetente
            Send.Remetente.Nome = "Hi Academia";
            //Send.Remetente.Email = "himarketing2019@gmail.com";
            Send.Remetente.Email = "marketing@hiacademia.com.br";

            // Dados Servidor
            Send.Host = "smtp.gmail.com";
            //Send.Host = "smtplw.com.br";
            Send.Port = 587;
            //Send.From = "marketing@hiacademia.com.br";
            //Send.Pass = "neves@506070";
            Send.From = "himarketing2019@gmail.com";
            Send.Pass = "root1526";

            // Dados Msg
            Send.Subject = Rtxt_titulo.Text;
            Send.UrlCampanha = txt_campanha.Text;
            Send.UrlImg = txt_img.Text;

        }
        public async Task EnviarAsync(String Tabela, Int32 Empresa_id) 
        {
            //Condições de controle
            Mail = new MailMessage();
            Con = new Connect();
            Hlp = new Hlp();
            Send = new EmailSendPST();

            using (SmtpClient Smtp = new SmtpClient()) 
            {
                try 
                {
                    Armazenar();

                    //Config Servidor Email
                    Smtp.Host = Send.Host;
                    Smtp.Port = Send.Port;
                    Smtp.EnableSsl = true;
                    Smtp.UseDefaultCredentials = false;
                    Smtp.Credentials = new NetworkCredential(Send.From, Send.Pass);

                    if (cb_filtros.Checked == true) 
                    {
                        DisplayData(Send.Pesquisar(Tabela, Empresa_id, Hlp.DateFormat(dtp_inicial.Text), Hlp.DateFormat(dtp_final.Text)));
                    } 
                    else
                    {
                        DisplayData(Send.Pesquisar(Tabela, Empresa_id));
                    }
                    
                    for (int Cont = 0; Cont < Table.Rows.Count; Cont++) 
                    {
                        await Task.Delay(3000);

                        Send.Destinatario = new Destinatario();

                        Send.Destinatario.Nome = Table.Rows[Cont]["nome"].ToString();
                        Send.Destinatario.Email = Table.Rows[Cont]["email"].ToString();
                        Send.Body = MsgFormat();

                        using (MailMessage Mail = new MailMessage())
                        {
                            Mail.From = new MailAddress(Send.From);

                            Mail.To.Add(new MailAddress(Send.Destinatario.Email));
                            //Mail.To.Add(new MailAddress("marlon.lira@hiacademia.com.br"));
                            Mail.Subject = Send.Subject;
                            Mail.IsBodyHtml = true;
                            Mail.Body = Send.Body;

                            Smtp.Send(Mail);

                            Enviados ++;
                            lbl_enviados.Text = "ENVIADOS: " + Enviados.ToString();
                            lbl_total.Text = "TOTAL: " + (Enviados + Falhas).ToString();
                            dataGridView2.Rows.Add(Send.Destinatario.Nome, "ENVIADO", Send.Destinatario.Email);
                            if (Parar == true) { break; }
                        }
                    }

                    lbl_enviados.Text = "ENVIADOS: " + Enviados.ToString();
                    lbl_falhas.Text = "FALHAS: " + Falhas.ToString();
                    lbl_total.Text = "TOTAL: " + (Enviados + Falhas).ToString();
                    MessageBox.Show("ENVIO CONCLUIDO!");
                } 
                catch (Exception e) 
                {
                    dataGridView2.Rows.Add(Send.Destinatario.Nome, "FALHA", Send.Destinatario.Email);
                    Falhas ++;
                    MessageBox.Show(e.Message);
                }
            }
        }
      
        private void btn_enviar_Click(object sender, EventArgs e) 
        {
            Parar = false;
            EnviarOperadores();
            String[] Part = cbb_unidade.Text.Split('-');
            EnviarAsync(cbb_destinatario.Text, Int32.Parse(Part[0]));
        }

        private void btn_voltar_Click(object sender, EventArgs e) 
        {
            Inicio.Show();
            this.Hide();
        }

        private void btn_cancelar_Click(object sender, EventArgs e) 
        {
            Parar = true;
        }

        private void FrmEmail_Load(object sender, EventArgs e)
        {

        }

        private void btn_testar_Click(object sender, EventArgs e) 
        {
            FrmTest Test = new FrmTest(this);
            Test.Show();
        }
    }
}
