using System.Data.SqlClient;

namespace TIGEST.Models
{
    internal class Conexao
    {
        protected SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-5UEM7OT;Initial Catalog=tigest;Integrated Security=True;"); 
     }
}
