using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIGEST.Functions
{
    public partial class Frm_Administracao: Form
    {
        Frm_Administracao frm_Administracao = new Frm_Administracao();

        public Frm_Administracao()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Administracao.Hide();
        }
    }
}
