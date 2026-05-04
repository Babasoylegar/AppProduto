using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appproduto
{
    public partial class frmsplash : Form
    {
        public frmsplash()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgbsplash.Value < 100)
            {
                pgbsplash.Value = Math.Min(pgbsplash.Value + 10, 100);
                label1.Text = pgbsplash.Value.ToString() + "%";
            }
            else
            {
                tmtsplash.Enabled = false;
                frmlogin frmlogin = new frmlogin();
                frmlogin.Show();
                this.Hide();
            }
        }
    }
}
