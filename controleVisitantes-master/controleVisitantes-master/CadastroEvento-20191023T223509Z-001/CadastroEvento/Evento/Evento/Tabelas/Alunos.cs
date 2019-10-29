using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evento.Tabelas
{
    class Alunos : Conexao
    {
        public int Id { get; set; }
        public string RA { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CarteirinhaEstudante { get; set; }
        public int Tipo { get; set; }

        public const string listarAlunos = "SELECT * FROM ALUNO";
        public const string inserirAlunos = "INSERT INTO ALUNO VALUES (@RA, @NOME, @EMAIL, @TELEFONE, @CARTEIRINHA_ESTUDANTE, @TIPO)";
        public const string apagarAlunos = "DELETE FROM ALUNO WHERE ID=@ID";


        private static Alunos RetornaAlunos(ref SqlDataReader DataReader)
        {
            Alunos entity = new Alunos
            {
                Id = Convert.ToInt32(DataReader["Id"].ToString()),
                RA = DataReader["RA"].ToString(),
                Nome = DataReader["Nome"].ToString(),
                Email = DataReader["Email"].ToString(),
                Telefone = DataReader["Telefone"].ToString(),
                CarteirinhaEstudante = DataReader["Carteirinha_Estudante"].ToString(),
                Tipo = Convert.ToInt32(DataReader["Tipo"].ToString())
            };

            return entity;
        }
        private static List<Alunos> ColecaoAlunos(ref List<Alunos> collection, ref SqlDataReader dataReader, SqlCommand dbCommand)
        {
            using (dataReader = dbCommand.ExecuteReader())
            {
                collection = new List<Alunos>();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                        collection.Add(RetornaAlunos(ref dataReader));
                }

                if (!(dataReader.IsClosed))
                    dataReader.Close();

                dataReader.Dispose();
            }

            return collection;
        }

        private List<Alunos> ListaAlunos()
        {
            SqlDataReader dataReader = null;
            List<Alunos> collection = null;

            try
            {
                using (ObjConexao)
                {
                    using (SqlCommand objComando = new SqlCommand(listarAlunos, ObjConexao))
                    {
                        objComando.CommandType = CommandType.Text;
                        ObjConexao.Open();
                        objComando.ExecuteNonQuery();
                        collection = ColecaoAlunos(ref collection, ref dataReader, objComando);
                        ObjConexao.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ObjConexao.State == ConnectionState.Open)
                    ObjConexao.Close();
                throw ex;
            }

            return collection;
        }

        public List<Alunos> ListarAlunos()
        {
            _ = new List<Alunos>();
            List<Alunos> listaDeAlunos = ListaAlunos();
            return listaDeAlunos;
        }

        public void DbInserir(string ra, string telefone, string nome, string email, string carteirinha, int tipo)
        {
            using (ObjConexao)
            {
                using (SqlCommand objComando = new SqlCommand(inserirAlunos, ObjConexao))
                {
                    objComando.Parameters.AddWithValue("@CARTEIRINHA_ESTUDANTE", carteirinha);
                    objComando.Parameters.AddWithValue("@RA", ra);
                    objComando.Parameters.AddWithValue("@NOME", nome);
                    objComando.Parameters.AddWithValue("@EMAIL", email);
                    objComando.Parameters.AddWithValue("@TELEFONE", telefone);
                    objComando.Parameters.AddWithValue("@TIPO", tipo);

                    ObjConexao.Open();
                    objComando.ExecuteNonQuery();
                    ObjConexao.Close();

                }
            }
        }
        public void DbApagar(int id)
        {
            using (ObjConexao)
            {
                using (SqlCommand objComando = new SqlCommand(apagarAlunos, ObjConexao))
                {
                    objComando.Parameters.AddWithValue("@id", id);

                    ObjConexao.Open();
                    objComando.ExecuteNonQuery();
                    ObjConexao.Close();

                }
            }
        }
    }
}
