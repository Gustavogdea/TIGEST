using System.Data.SqlClient;

namespace TIGEST.Model
{
    internal class Conexao
    {
        protected SqlConnection conexao = new SqlConnection(@"Data Source=dsqlapp039-01br;Initial Catalog=db_tigest;User ID=ppe;Password=ppe;Encrypt=False");
     }
}
