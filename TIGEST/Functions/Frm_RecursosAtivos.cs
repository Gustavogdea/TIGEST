using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;
using TIGEST.Models;
using System.Runtime.InteropServices;

namespace TIGEST
{
    public partial class Frm_RecursosAtivos : Form
    {
        public Frm_RecursosAtivos()
        {
            InitializeComponent();
        }

        private void Menu_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_CarregarQwerty_Click(object sender, EventArgs e)
        {
            string nomeObjeto = Txt_NomeObjeto.Text;
            string numSerie = Txt_NumSerie.Text;
            string numBP = Txt_NumBP.Text;
            bool ativoAd = Ckb_AtivoAd.Checked ? true : false;
            bool excluidoAd = Ckb_NaoAtivoAd.Checked ? true : false;
            bool naoAplicaAd = Ckb_NaAtivoAd.Checked ? true : false;

            Dados dados = new Dados();
            DataTable tabela = dados.CarregarDadosAtivos(nomeObjeto, numSerie, numBP, ativoAd, excluidoAd, naoAplicaAd);

            if (tabela.Rows.Count > 0)
            {
                Dgv_DataRecursos.DataSource = tabela;
            }
            else
            {
                MessageBox.Show("Nenhum dado encontrado na tabela.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
