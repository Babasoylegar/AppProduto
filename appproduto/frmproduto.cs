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
    public partial class frmproduto : Form
    {
        public frmproduto()
        {
            InitializeComponent();
            CampoDisable();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            CampoEnable();
        }
        private void CampoEnable()
        {
            txtvalor.Enabled = true;
            txtnome.Enabled = true;
            txtquantidade.Enabled = true;
            
        }
        private void CampoDisable()
        {
            txtnome.Enabled = false;
            txtquantidade.Enabled = false;
            txtvalor.Enabled = false;
        }
        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            txtquantidade.Clear();
            txtvalor.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
