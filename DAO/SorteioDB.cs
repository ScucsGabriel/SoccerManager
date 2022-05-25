using SoccerManager.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerManager.DAO
{
    class SorteioDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal Sorteio InserirSorteio(int idUsu, int idTime, int divisao)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlQuery = "INSERT INTO Sorteio(idSorteioUsuario, idSorteioTime, divisao)" +
                              " VALUES (@idUsu, @idTime, @divisao)";
            SqlCommand comando = new SqlCommand(sqlQuery, conn);
            comando.Parameters.Add(new SqlParameter("@idUsu", idUsu));
            comando.Parameters.Add(new SqlParameter("@idTime", idTime));
            comando.Parameters.Add(new SqlParameter("@divisao", divisao));

            try
            {
                conn.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um problema na gravação de dados: " + ex);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }

        internal List<Sorteio> ConsultarTodoSorteio()
        {
            List<Sorteio> lstSorteio = new List<Sorteio>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT s.idSorteio, s.idSorteioUsuario, u.nomeUsuario, u.emailUsuario, s.idSorteioTime, t.time, s.divisao" +
                               " FROM Sorteio AS s" +
                               " INNER JOIN Usuario AS u ON idSorteioUsuario = u.idUsuario" +
                               " INNER JOIN Time AS t ON s.idSorteioTime = t.idTime";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Sorteio sorteio = new Sorteio();
                Usuario usuario = new Usuario();
                Time time = new Time();
                sorteio.idSorteio = Convert.ToInt32(dr["idSorteio"].ToString());
                sorteio.idSorteioUsuario = Convert.ToInt32(dr["idSorteioUsuario"].ToString());
                usuario.nomeUsuario = dr["nomeUsuario"].ToString();
                sorteio.usuario.nomeUsuario = usuario.nomeUsuario;
                usuario.emailUsuario = dr["emailUsuario"].ToString();
                sorteio.usuario.emailUsuario = usuario.emailUsuario;
                sorteio.idSorteioTime = Convert.ToInt32(dr["idSorteioTime"].ToString());
                time.time = dr["time"].ToString();
                sorteio.time.time = time.time;
                sorteio.divisao = Convert.ToInt32(dr["divisao"].ToString());


                lstSorteio.Add(sorteio);
            }
            conn.Close();

            return lstSorteio;
        }

        internal Sorteio ContarSorteioPorDivisao(int divisao)
        {
            Sorteio sorteioResultado = new Sorteio();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT COUNT(*) AS contagemDivisao FROM Sorteio WHERE divisao = " + divisao;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                sorteioResultado.contagemDivisao = Convert.ToInt32(dr["contagemDivisao"].ToString());
            }
            conn.Close();

            return sorteioResultado;
        }

        internal List<Sorteio> ContarSorteioDiv1()
        {
            List<Sorteio> lstSorteio = new List<Sorteio>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Sorteio WHERE divisao = 1";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Sorteio sorteio = new Sorteio();
                sorteio.idSorteio = Convert.ToInt32(dr["idSorteio"].ToString());

                lstSorteio.Add(sorteio);
            }
            conn.Close();

            return lstSorteio;
        }

        internal List<Sorteio> ContarSorteioDiv2()
        {
            List<Sorteio> lstSorteio = new List<Sorteio>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Sorteio WHERE divisao = 2";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Sorteio sorteio = new Sorteio();
                sorteio.idSorteio = Convert.ToInt32(dr["idSorteio"].ToString());

                lstSorteio.Add(sorteio);
            }
            conn.Close();

            return lstSorteio;
        }

        internal Sorteio ConsultarSorteioPorTime(int idTime)
        {
            Sorteio sorteioTime = new Sorteio();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT COUNT(*) AS contagemTime FROM Sorteio WHERE idSorteioTime = " + idTime;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                sorteioTime.contagemTime = Convert.ToInt32(dr["contagemTime"].ToString());
            }
            conn.Close();

            return sorteioTime;
        }
        internal Sorteio ConsultarSorteioPorUsuario(int idUsu)
        {
            Sorteio sorteioUsuario = new Sorteio();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT COUNT(*) AS contagemUsuario FROM Sorteio WHERE idSorteioUsuario = " + idUsu;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                sorteioUsuario.contagemUsuario = Convert.ToInt32(dr["contagemUsuario"].ToString());
            }
            conn.Close();

            return sorteioUsuario;
        }
        internal Sorteio ExcluirSorteio()
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "DELETE FROM Sorteio;" +
                               " DBCC CHECKIDENT('Sorteio', RESEED, 0)";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Houve um problema na exclusão: " + e);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }
    }
}
