using System;
using System.Collections.Specialized;
using System.Data;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MsgZap.Helper;
using MsgZap.Model;
using MsgZap.Persistence;

namespace MsgZap {
    public partial class FrmBase : Form
    {
        public readonly Encoding HTTP_ENCODING = Encoding.UTF8;

        private const String URL_PLATFORM = "https://apizap.me:8443/api";
        private const String TOKEN = "I8B4A95J-3LHG-2G3D-C2EF-7CB93I21G6H8";
        private const String SUCCESS = "{\"message\":\"sucesso\"}";
        private const String REMETENTE = "REMETENTE";
        private const String TESTE_DESTINATARIO = "DESTINATARIO";

        DataTable Table;
        Connect Con;
        WhatsAppSendPST Send;
        FrmHome Inicio;

        //Variaveis de controle
        Boolean Parar;
        Int32 Contador = 0;

        public FrmBase(FrmHome Frm)
        {
            InitializeComponent();

            Inicio = Frm;
            cb_testar.Checked = false;
            dtp_final.Text = DateTime.Now.ToShortDateString();
        }

        #region News 

        public void EnviarOperadores() 
        {
            String[] NumOperador = { "", "", "", "" };
            String[] NameOperador = { "CAROL", "NEWTON", "KILDERE", "MARLON" };
            try 
            {
                for (int x = 0; x <= 3; x++) {
                    WebReq(URL_PLATFORM, NumOperador[x], NameOperador[x]);
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void DisplayData(String Script)
        {
            Con.OpenCon();
            Table = new DataTable();
            Con.OpenAdpter(Script);
            Con.Adapt.Fill(Table);
            Con.CloseCon();
        }

        public void MsgPersonalizada(String Header, String Body, String Footer)            
        {
            Rtxt_Texto.Text = "        *" + Header + "*" + "\n\n" + Body + "\n\n" + Footer;
        }

        public async Task EnviarAsync(String Tabela, Int32 Empresa_id)
        {
            String TelFormat = "";
            Int32 Enviados = 0;
            Int32 Falhas = 0;
            WhatsAppSendPST App;
            Hlp Hlp;

            try
            {
                App = new WhatsAppSendPST();
                Con = new Connect();
                Hlp = new Hlp();

                EnviarOperadores();

                if (cb_filtros.Checked == true) 
                {
                    DisplayData(App.Pesquisar(Tabela, Empresa_id, Hlp.DateFormat(dtp_inicial.Text), Hlp.DateFormat(dtp_final.Text)));
                }
                else 
                {
                    DisplayData(App.Pesquisar(Tabela, Empresa_id));
                }

                for (int Cont = 0; Cont < Table.Rows.Count; Cont++)
                {
                    //Controles
                    if (Parar == true) { break; }
                    if (Contador > 1000) { Contador = 0; }

                    // Timer
                    await Task.Delay(Hlp.WaitTime(Contador));
                    
                    App.Destinatario = new Destinatario();

                    App.Destinatario.Nome = Table.Rows[Cont]["nome"].ToString();
                    App.Destinatario.Telefone = Hlp.TelFind(Table, Tabela, Cont);

                    if (!String.IsNullOrEmpty(App.Destinatario.Telefone))
                    {
                       TelFormat =  Hlp.TelFormat(App.Destinatario.Telefone);
                    }

                    if (!String.IsNullOrEmpty(TelFormat))
                    {

                        if (cb_testar.Checked == false) 
                        {
                            WebReq(URL_PLATFORM, TelFormat, App.Destinatario.Nome);
                        } 
                        else 
                        {
                            WebReq(URL_PLATFORM, TESTE_DESTINATARIO, App.Destinatario.Nome);
                            break;
                        }
                        
                        Enviados++;
                        lbl_enviados.Text = "ENVIADOS: " + Enviados.ToString();
                        lbl_total.Text = "TOTAL: " + (Enviados + Falhas).ToString();
                    }
                    else
                    {
                        dataGridView2.Rows.Add(App.Destinatario.Nome, App.Destinatario.Telefone, "FALHA");
                        Falhas++;
                        lbl_falhas.Text = "FALHAS: " + Falhas.ToString();
                        lbl_total.Text = "TOTAL: " + (Enviados + Falhas).ToString();
                    }
                    Contador ++;
                }
                
                lbl_enviados.Text = "ENVIADOS: " + Enviados.ToString();
                lbl_falhas.Text = "FALHAS: " + Falhas.ToString();
                lbl_total.Text = "TOTAL: " + (Enviados + Falhas).ToString();
                MessageBox.Show("O ENVIO FOI CONCLUIDO!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        #endregion

        public void WebReq(String ApiUrl, String Tel, String Nome)
        {
            String Result = "";
            String TextFormat = "";
            WhatsAppSendPST Send;
            Hlp Hlp;
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => { return true; };
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            using (WebClient WebPost = new WebClient())
            {
                NameValueCollection WebFields = null;
                Byte[] WebResponse = null;

                try
                {
                    Hlp = new Hlp();
                    Send = new WhatsAppSendPST();
                    WebFields = new NameValueCollection();

                    Send.Cmd = "chat";

                    String[] NomeFormat = Nome.Split(' ');
                    TextFormat = Rtxt_Texto.Text.Replace("{nome}", NomeFormat[0]);
                    TextFormat = TextFormat.Replace("{hix}", "Texto fixo Hix");
                    TextFormat = TextFormat.Replace("{hi}", "Texto fixo Hi");
                    TextFormat = TextFormat.Replace("{comprimento}", Hlp.RandomTalk());
                    TextFormat = TextFormat.Replace("{comprimentoplus}", Hlp.RandomTalk(NomeFormat[0]));
                    Send.Texto = TextFormat;

                    if (!String.IsNullOrEmpty(txt_img.Text))
                    {
                        Send.Cmd = "image";
                        Send.UrlImg = txt_img.Text;
                    }

                    /*
                     * 
                    //Waboxapp
                    WebFields["token"] = TOKEN;
                    WebFields["uid"] = REMETENTE;
                    WebFields["to"] = Tel;
                    WebFields["custom_uid"] = Hlp.RandomIdGenerator();
                    WebFields["text"] = Send.Texto;

                    if (!String.IsNullOrEmpty(txt_img.Text)) 
                    {
                        WebFields["url"] = Send.UrlImg;
                        WebFields["caption"] = Send.Titulo;
                        WebFields["description"] = Send.Descricao;
                    }
                    */

                    //Winzap
                    WebFields["token"] = TOKEN;
                    WebFields["cmd"] = Send.Cmd;
                    WebFields["id"] = Hlp.RandomIdGenerator();
                    WebFields["de"] = REMETENTE;
                    WebFields["para"] = Tel;
                    WebFields["msg"] = Send.Texto;
                    if (!String.IsNullOrEmpty(txt_img.Text))
                    {
                        WebFields["link"] = Send.UrlImg;
                    }

                    MessageBox.Show(Send.Texto);
                    //WebResponse = WebPost.UploadValues(ApiUrl, "POST", WebFields);
                    //Result = HTTP_ENCODING.GetString(WebResponse);
                    Result = "{\"message\":\"sucesso\"}";
                    if (Result == SUCCESS)
                    {
                        dataGridView2.Rows.Add(Nome, Tel, "ENVIADO");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + "");
                }
                finally
                {
                    WebFields = null;
                    WebResponse = null;
                }
            }
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            Contador = 0;
            Parar = false;
            cb_testar.Checked = false;

            if(String.IsNullOrEmpty(cbb_destinatario.Text) || String.IsNullOrEmpty(cbb_unidade.Text) || String.IsNullOrEmpty(Rtxt_Texto.Text))
            {
                if (String.IsNullOrEmpty(Rtxt_Texto.Text))
                {
                    MessageBox.Show("POR FAVOR ESCREVA A MENSAGEM QUE DESEJA ENVIAR!");
                }
                else
                {
                    MessageBox.Show("POR FAVOR ESCOLHA O DESTINATARIO E A UNIDADE!");
                }
            }
            else
            {
                MessageBox.Show("AGUARDE ENQUANTO TODOS TELEFONES SÃO VERIFICADOS E AS MENSAGENS ENVIADAS...");
                String[] Part = cbb_unidade.Text.Split('-');
                EnviarAsync(cbb_destinatario.Text, Int32.Parse(Part[0]));
            }
            
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            Parar = false;
        }

        private void btn_testar_Click(object sender, EventArgs e)
        {
            Contador = 0;
            Parar = false;
            cb_testar.Checked = true;

            if (String.IsNullOrEmpty(cbb_destinatario.Text) || String.IsNullOrEmpty(cbb_unidade.Text) || String.IsNullOrEmpty(Rtxt_Texto.Text)) {
                if (String.IsNullOrEmpty(Rtxt_Texto.Text))
                {
                    MessageBox.Show("POR FAVOR ESCREVA A MENSAGEM QUE DESEJA ENVIAR!");
                } else {
                    MessageBox.Show("POR FAVOR ESCOLHA O DESTINATARIO E A UNIDADE!");
                }
            } else  
            {
                MessageBox.Show("AGUARDE... O TESTE ESTÁ SENDO INICIADO");
                String[] Part = cbb_unidade.Text.Split('-');
                EnviarAsync(cbb_destinatario.Text, Int32.Parse(Part[0]));
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Parar = true;
            Contador = 0;
        }

        private void btn_personalizar_Click(object sender, EventArgs e) 
        {
            FrmMsg Msg = new FrmMsg(this);
            Msg.Show();
            this.Hide();
        }

        private void btn_voltar_Click(object sender, EventArgs e) 
        {
            Inicio.Show();
            this.Hide();
        }
       
    }
}
