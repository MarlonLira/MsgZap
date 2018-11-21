using MsgZap.Helper;
using MsgZap.Model;
using System;
using System.Collections.Specialized;
using System.Data;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MsgZap
{
    public partial class FrmInicio : Form
    {

        DataTable Table;
        public readonly Encoding HTTP_ENCODING = Encoding.UTF8;

        private const String TOKEN = "D913IM05-39E7-JIM9-9J0H-FJ63DIMC9G7H";
        private const String URL_PLATFORM = "https://apizap.me:8443/api?";
        private const String SUCCESS = "{\"message\":\"sucesso\"}";

        public FrmInicio()
        {
            InitializeComponent();

            txt_remetente.Text = "558183460962";
            txt_destinatario.Text = "5581986732729";
        }

        public void Enviar()
        {
            WebReq(URL_PLATFORM);
        }

        public void WebReq(String ApiUrl)
        {
            String Result = "";
            WhatsAppSend Send;
            Hlp Helper;

            using (WebClient WebPost = new WebClient())
            {
                NameValueCollection WebFields = null;

                Byte[] WebResponse = null;
                try
                {

                    Helper = new Hlp();
                    Send = new WhatsAppSend();
                    WebFields = new NameValueCollection();

                    WebFields["token"] = TOKEN;
                    WebFields["cmd"] = "chat";
                    WebFields["id"] = Helper.RandomIdGenerator();
                    WebFields["de"] = txt_remetente.Text;
                    WebFields["para"] = txt_destinatario.Text;
                    WebFields["msg"] = Rtxt_texto.Text;

                    //WebResponse = WebPost.UploadValues(ApiUrl, "POST", WebFields);
                    //Result = HTTP_ENCODING.GetString(WebResponse);
                    Result = "{\"message\":\"sucesso\"}";

                    if (Result == SUCCESS)
                    {
                        //MessageBox.Show("Enviado com Sucesso!");
                        Table = new DataTable();

                        dataGridView1.Rows.Add(txt_remetente.Text,txt_destinatario.Text, "ENVIADO");

                    }

                    #region OUTROS MODOS

                    // MODO 2
                    /*ASCIIEncoding Encoding = new ASCIIEncoding();
                    String DataPost = "token=" + TOKEN + "&cmd=chat" + "&id=1"+ "&de=5581983460962" + "&para=5581986732729" + "&msg=" + Rtxt_texto.Text;
                    WebResponse = Encoding.GetBytes(DataPost);

                    WebRequest Request = WebRequest.Create("https://apizap.me:8443/api?");
                    Request.Method = "POST";
                    Request.ContentType = "application/x-www-form-urlencoded";
                    Request.ContentLength = WebResponse.Length;
                    
                    
                    Request.UseDefaultCredentials = true;
                    Request.PreAuthenticate = true;
                    Request.Credentials = CredentialCache.DefaultCredentials;

                    Stream stream = Request.GetRequestStream();
                    stream.Write(WebResponse, 0, WebResponse.Length);

                    WebResponse Response = Request.GetResponse();
                    stream = Response.GetResponseStream();

                    StreamReader sr = new StreamReader(stream);
                    MessageBox.Show(sr.ReadToEnd());
                    sr.Close();
                    stream.Close();*/

                    //RESTSHARP
                    /*String DataPost = "token=" + TOKEN + "&cmd=chat" + "&id=msg-2724" + "&de=558183460962" + "&para=5581986732729" + "&msg=" + Rtxt_texto.Text;

                    var client = new RestClient("https://apizap.me:8443/api");
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("content-type", "application/x-www-form-urlencoded");
                    request.AddParameter("application/x-www-form-urlencoded", DataPost, ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);
                    */

                    #endregion
                }
                catch (Exception e)
                {
                   MessageBox.Show(e.Message + " Verifique as INFORMAÇÕES Digitadas!");
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
            Enviar();
        }
    }
}
