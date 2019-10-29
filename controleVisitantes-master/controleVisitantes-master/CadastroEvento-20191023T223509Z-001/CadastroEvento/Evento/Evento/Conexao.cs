using System.Configuration;
using System.Data.SqlClient;

namespace Evento
{
    class Conexao
    {
        static readonly string strConnect = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private readonly SqlConnection objConexao = new SqlConnection(strConnect);

        public SqlConnection ObjConexao => objConexao;
    }

    
}
