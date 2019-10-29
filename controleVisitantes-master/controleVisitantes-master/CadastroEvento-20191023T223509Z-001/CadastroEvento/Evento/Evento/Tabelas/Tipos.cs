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
    class Tipos : Conexao
    {
        public int Id { get; set; }
        public string Tipo { get; set; }

        public const string listarTipos = "SELECT * FROM TIPO";
        public const string inserirTipos = "INSERT INTO TIPO VALUES (@TIPO)";
        public const string apagarTipos = "DELETE FROM TIPO WHERE ID=@ID";


        private static Tipos RetornaTipos(ref SqlDataReader DataReader)
        {
            Tipos entity = new Tipos
            {
                Id = Convert.ToInt32(DataReader["Id"].ToString()),
                Tipo = DataReader["TIPO"].ToString()
            };

            return entity;
        }
        private static List<Tipos> ColecaoTipos(ref List<Tipos> collection, ref SqlDataReader dataReader, SqlCommand dbCommand)
        {
            using (dataReader = dbCommand.ExecuteReader())
            {
                collection = new List<Tipos>();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                        collection.Add(RetornaTipos(ref dataReader));
                }

                if (!(dataReader.IsClosed))
                    dataReader.Close();

                dataReader.Dispose();
            }

            return collection;
        }

        private List<Tipos> ListaTipos()
        {
            SqlDataReader dataReader = null;
            List<Tipos> collection = null;

            try
            {
                using (ObjConexao)
                {
                    using (SqlCommand objComando = new SqlCommand(listarTipos, ObjConexao))
                    {
                        objComando.CommandType = CommandType.Text;
                        ObjConexao.Open();
                        objComando.ExecuteNonQuery();
                        collection = ColecaoTipos(ref collection, ref dataReader, objComando);
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

        public List<Tipos> ListarTipos()
        {
            _ = new List<Tipos>();
            List<Tipos> listaDeTipos = ListaTipos();
            return listaDeTipos;
        }

        public void DbInserir(int tipo)
        {
            using (ObjConexao)
            {
                using (SqlCommand objComando = new SqlCommand(inserirTipos, ObjConexao))
                {
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
                using (SqlCommand objComando = new SqlCommand(apagarTipos, ObjConexao))
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
