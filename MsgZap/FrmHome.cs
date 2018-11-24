using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsgZap 
{
    public partial class FrmHome : Form 
    {
        public FrmHome() 
        {
            InitializeComponent();
        }

        private void whatsAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBase MsgZap = new FrmBase(this);

            MsgZap.Show();
            this.Hide();
            
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            FrmEmail Email = new FrmEmail(this);

            Email.Show(this);
            this.Hide();
        }

        private void btn_whats_Click(object sender, EventArgs e)
        {
            FrmBase MsgZap = new FrmBase(this);

            MsgZap.Show();
            this.Hide();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void btn_emails_Click(object sender, EventArgs e)
        {
            FrmEmail Email = new FrmEmail(this);

            Email.Show(this);
            this.Hide();
        }
    }
}
