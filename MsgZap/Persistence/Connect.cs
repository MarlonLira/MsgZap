using System.Data.SqlClient;
using System.Configuration;

namespace MsgZap.Persistence {
    class Connect {

        // Conexão sql 

        public string CreateCon = ConfigurationManager.ConnectionStrings["MsgZap.Properties.Settings.gestor2ConnectionString"].ConnectionString;
        public SqlConnection Con;
        public SqlCommand Cmd;
        public SqlDataAdapter Adapt;

        /*Conexão banco*/

        public void OpenCon() {
            Con = new SqlConnection(CreateCon);
            Con.Open();
        }

        public void OpenAdpter(string tabela) {
            Adapt = new SqlDataAdapter(tabela, Con);
        }

        public void CloseCon() {
            Con.Close();
        }
    }
}
