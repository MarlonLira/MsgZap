using System;

namespace MsgZap.Model {
    class WhatsAppSend {

        public Int32 Id { get; set; }
        public Remetente Remetente { get; set; }
        public Destinatario Destinatario { get; set; }
        public String Chave { get; set; }
        public String Texto { get; set; }
        public String Token { get; set; }
        public String Cmd { get; set; }

        //Envio de Img
        public String UrlImg { get; set; }

        //msg com link opcionais
        public String Titulo { get; set; }
        public String Descricao { get; set; }
        public String UrlMsg { get; set; }
    }
}
