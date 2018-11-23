using System;
using MsgZap.Model;

namespace MsgZap.Connect {
    class WinzapCon : WhatsAppSend {

        private const String URL_PLATFORM = "https://apizap.me:8443/api?";
        private const String TOKEN = "D913IM05-39E7-JIM9-9J0H-FJ63DIMC9G7H";
        public Int32 Count;
        

        public String CriarLink() {

            Count++;
            Token = TOKEN;
            Id = Count;

            String Link = URL_PLATFORM;

            return Link;
        }

    }
}
