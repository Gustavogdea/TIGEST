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

namespace TIGEST
{
    public partial class Frm_RecursosAtivos : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=dsqlapp039-01br;Initial Catalog=db_tigest;User ID=ppe;Password=ppe;Encrypt=False");
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
            CarregarDados();
        }
        private void CarregarDados()
        {
            conexao.Open();
            string query = @"SELECT nomeRecurso as 'Nome Recurso', categoria as 'Categoria', tipo as 'Tipo', departamento as 'Departamento', localizacao as 'Local', numeroSerie as 'Número de Série', observacao as 'Notas', numeroBp 'N° BP', usuarioResp as 'Responsável', usuario.id_Nome as 'Responsável TI', ativoAd as 'AD Status', invent.DatIncReg as 'Data Registro', invent.flagAtivo as 'Status' FROM TbInventario invent inner join tbCategoria categoria on invent.id_Categoria = categoria.id inner join tbTipo tipo on invent.id_Tipo = tipo.id inner join tbLocal loc on invent.id_Localizacao = loc.id inner join tbDepartamento dp on invent.id_Departamento = dp.id inner join tbUsuario usuario on invent.respPelaAdicao = usuario.id WHERE invent.flagAtivo = 1";

            using (SqlCommand cmd = new SqlCommand(query, conexao)) 
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    int v = adapter.Fill(tabela);

                    if (tabela.Rows.Count > 0)
                    {
                        Dgv_DataRecursos.DataSource = tabela;
                        conexao.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum dado encontrado na tabela.");
                        conexao.Close();
                    }
                }
            }
        }
    }
}
