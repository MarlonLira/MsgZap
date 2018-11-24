using MsgZap.Model;
using System;

namespace MsgZap.Persistence
{
    class WhatsAppSendPST : WhatsAppSend
    {
        public String Pesquisar(String Tabela) { return "SELECT * FROM FITNESS.TBL_" + Tabela; }
        public String Pesquisar(String Tabela, Int32 Empresa_id) { return "SELECT * FROM FITNESS.TBL_" + Tabela + " WHERE EMPRESA_ID = " + Empresa_id; }
        public String Pesquisar(String Tabela, Int32 Empresa_id, String DateInicial, String DateFinal) { return "SELECT * FROM FITNESS.TBL_" + Tabela + " WHERE EMPRESA_ID = " + Empresa_id + " AND DATA_ULTIMO_ACESSO BETWEEN " + "'"+ DateInicial + "'" + " AND " + "'" + DateFinal + "'"; }
    }
}
