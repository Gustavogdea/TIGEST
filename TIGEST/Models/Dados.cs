using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TIGEST.Models
{
    internal class Dados : Conexao
    {
        public DataTable CarregarDadosAtivos(string nomeObjeto, string numSerie, string numBP, string usuarioResp, string usuarioTIResp, string localizacao, string departamento,bool ativoAd, bool excludoAd, bool naoAplicaAd, bool itensDeletados)
        {
            string atValue = ""; 
            string exValue = "";
            string nAValue = "";
            if (nomeObjeto == null || nomeObjeto == "") { nomeObjeto = ""; }
            if (numSerie == null || numSerie == "") { numSerie = ""; }
            if (numBP == null || numBP == "") { numBP = ""; }
            if (usuarioResp == null || usuarioResp == "") { usuarioResp = ""; }
            if (ativoAd) { atValue = "A"; }
            if (excludoAd) { exValue = "E"; }
            if (naoAplicaAd) { nAValue = "N"; }
            byte itensDeletadosValue = Convert.ToByte(itensDeletados);
            conexao.Open();
            {

            }
            string query = $"SELECT nomeRecurso as 'Nome Recurso', categoria as 'Categoria', tipo as 'Tipo', departamento as 'Departamento', localizacao as 'Local', numeroSerie as 'Número de Série', observacao as 'Notas', numeroBp 'N° BP', usuarioResp as 'Responsável', usuario.id_Nome as 'Responsável TI', ativoAd as 'AD Status', invent.DatIncReg as 'Data Registro', invent.flagAtivo as 'Status' FROM TbInventario invent inner join tbCategoria categoria on invent.id_Categoria = categoria.id inner join tbTipo tipo on invent.id_Tipo = tipo.id inner join tbLocal loc on invent.id_Localizacao = loc.id inner join tbDepartamento dp on invent.id_Departamento = dp.id inner join tbUsuario usuario on invent.respPelaAdicao = usuario.id WHERE invent.flagAtivo = 1 and nomeRecurso like '{nomeObjeto}%' and numeroSerie like '{numSerie}%' and numeroBp like '{numBP}%' and ativoAd in ('{atValue}', '{exValue}', '{nAValue}') and invent.flagAtivo = {itensDeletadosValue} and usuarioResp like '{usuarioResp}%' and usuario.id_Nome like '{usuarioTIResp}%'";
            
            using (SqlCommand cmd = new SqlCommand(query, conexao))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    int v = adapter.Fill(tabela);
                    conexao.Close();
                    return tabela;
                }
            }
        }
    }
}
