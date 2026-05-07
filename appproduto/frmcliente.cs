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
    public partial class v : Form
    {
        public v()
        {
            InitializeComponent();
            DisableCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcpf.Clear();
            txtnome.Clear();
            txtrg.Clear();
        }

        private void v_Load(object sender, EventArgs e)
        {

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            EnableCampos();
        }
        private void DisableCampos()
        {
            txtcpf.Enabled = false;
            txtnome.Enabled = false;
            txtrg.Enabled = false;
        }
        private void EnableCampos()
        {
            txtcpf.Enabled = true;
            txtnome.Enabled = true;
            txtrg.Enabled = true;
        }

        private void btnbvoltar_Click(object sender, EventArgs e)
        {
            frmmenu frmmenu = new frmmenu();
            frmmenu.Show();
            this.Hide();
        }
    }
}
