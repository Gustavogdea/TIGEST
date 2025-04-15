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
            string usuarioResp = Txt_UserResp.Text; //
            string usuarioTIResp = Cbo_RespTI.Text;
            string localizacao = Cbo_Local.Text;
            string departamento = Cbo_Departamento.Text;
            bool ativoAd = Ckb_AtivoAd.Checked ? true : false;
            bool excluidoAd = Ckb_NaoAtivoAd.Checked ? true : false;
            bool naoAplicaAd = Ckb_NaAtivoAd.Checked ? true : false;
            bool itensDeletados = Ckb_ItensDeletados.Checked ? true : false;

            Dados dados = new Dados();
            DataTable tabela = dados.CarregarDadosAtivos(nomeObjeto, numSerie, numBP, usuarioResp, usuarioTIResp, localizacao, departamento, ativoAd, excluidoAd, naoAplicaAd, itensDeletados);

            if (tabela.Rows.Count > 0)
            {
                //Dgv_DataRecursos.DataSource = tabela;
                Dgv_DataRecursos.Rows.Clear(); // Limpa DataGridView
                foreach(DataRow row in tabela.Rows)
                {
                    int index = Dgv_DataRecursos.Rows.Add();
                    Dgv_DataRecursos.Rows[index].Cells["Cln_Name"].Value = row["Nome Recurso"];
                    Dgv_DataRecursos.Rows[index].Cells["Cln_Categoria"].Value = row["Categoria"];
                    Dgv_DataRecursos.Rows[index].Cells["Cln_Tipo"].Value = row["Tipo"];
                    Dgv_DataRecursos.Rows[index].Cells["Cln_Departamento"].Value = row["Departamento"];
                    Dgv_DataRecursos.Rows[index].Cells["Cln_Local"].Value = row["Local"];
                    Dgv_DataRecursos.Rows[index].Cells["Cln_NumeroSerie"].Value = row["Número de Série"];
                    Dgv_DataRecursos.Rows[index].Cells["Cln_NumeroBP"].Value = row["N° BP"];
                    Dgv_DataRecursos.Rows[index].Cells["Cln_Observacao"].Value = row["Observacao"];
                    Dgv_DataRecursos.Rows[index].Cells["Cln_ResponsavelEquipamento"].Value = row["Responsável"];
                    Dgv_DataRecursos.Rows[index].Cells["Cln_RespTI"].Value = row["Responsável TI"];
                    Dgv_DataRecursos.Rows[index].Cells["Cln_DatReg"].Value = row["Data Registro"];
                    Dgv_DataRecursos.Rows[index].Cells["Cln_AtivoAd"].Value = row["AD Status"];
                    Dgv_DataRecursos.Rows[index].Cells["Cln_Status"].Value = row["Status"];
                }

            }
            else
            {
                MessageBox.Show("Nenhum dado encontrado na tabela.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
