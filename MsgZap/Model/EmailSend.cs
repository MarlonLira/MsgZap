using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsgZap.Model 
{
    class EmailSend 
    {
        public String Host { get; set; }
        public Int32 Port { get; set; }
        public String From { get; set; }
        public String Pass { get; set; }
        //public String To { get; set; }
        public String Body { get; set; }
        public String Subject { get; set; }
        //public String Title { get; set; }
        public String UrlImg { get; set; }
        public String UrlCampanha { get; set; }
        public Remetente Remetente { get; set; }
        public Destinatario Destinatario { get; set; }
    }
}
