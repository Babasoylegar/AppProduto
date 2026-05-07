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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            v frmcliente = new v();
            frmcliente.Show();
            this.Hide();
        }

        private void btnproduto_Click(object sender, EventArgs e)
        {
            frmproduto frmproduto = new frmproduto();
            frmproduto.Show();
            this.Hide();
        }
    }
}
