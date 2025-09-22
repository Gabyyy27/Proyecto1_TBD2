using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_TBD2
{
    public partial class ReplicationForm : Form
    {
        public string PgHost { get; private set; }
        public string PgDatabase { get; private set; }
        public string PgUser { get; private set; }
        public string PgPassword { get; private set; }


        public ReplicationForm()
        {
            InitializeComponent();

        }

        private void btn_Sincronizar_Click(object sender, EventArgs e)
        {

            PgHost = txtHost.Text;
            PgDatabase = txtDatabase.Text;
            PgUser = txtUser.Text;
            PgPassword = txtPassword.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
