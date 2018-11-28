using MsgZap.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsgZap.Frm.Reports
{
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
        }

        private OleDbConnection _olecon;
        private OleDbCommand _oleCmd;

        private static String _Arquivo = @"C:\dados\Excel\Empregados.xlsx";
        private String _StringConexao = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0 Xml;HDR=YES;ReadOnly=False';", _Arquivo);
        private String _Consulta;
        
        private void FormExcel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_oleCmd != null)
            {
                _oleCmd.Parameters.Clear();
                _oleCmd.Dispose();
            }

            _oleCmd = null;

            if (_olecon != null)
            {
                if (_olecon.State == ConnectionState.Open)
                    _olecon.Close();

                _olecon.Dispose();
            }

            _olecon = null;
        }
        private void FormExcel_Load(object sender, EventArgs e)
        {
            try
            {
                _olecon = new OleDbConnection(_StringConexao);
                _olecon.Open();

                _oleCmd = new OleDbCommand();
                _oleCmd.Connection = _olecon;
                _oleCmd.CommandType = CommandType.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CreateReport()
        {
            String Aux = "";
            ReportsPst Reports = new ReportsPst();
            _Consulta = Reports.ItauList();

            _oleCmd.CommandText = _Consulta;
            _oleCmd.Parameters.Add("@id", OleDbType.Integer).Value = Convert.ToInt32(Aux.ToString());
            _oleCmd.Parameters.Add("@Nome", OleDbType.VarChar, 255).Value = Aux;
            _oleCmd.ExecuteNonQuery();

            _oleCmd.Parameters.Clear();

            MessageBox.Show("Dados Incluídos...");
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
