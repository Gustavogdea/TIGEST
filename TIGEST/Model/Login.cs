using System.Data.SqlClient;
using System.Runtime.Remoting;
namespace TIGEST.Model
{
    internal class Login : Conexao
    {

        public int BuscarUsuario(string nome, string senha)
        {
            conexao.Open();
            string query = $"SELECT * FROM tbUsuario WHERE id_Nome = @nome and id_senha = @senha";
            using (SqlCommand cmd = new SqlCommand(query, conexao))
            {
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@senha", senha);
                int count = (cmd.ExecuteScalar() as int?) ?? 0; // Retorna o número de registros encontrados
                return count;
            }
        }
        public void FecharConexao()
        {
            conexao.Close();
        }
    }
}