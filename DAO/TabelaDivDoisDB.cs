using SoccerManager.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace SoccerManager.DAO
{
    class TabelaDivDoisDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal TabelaDivDois InserirTabelaDivDois(List<Sorteio> sorteiosSelecionados)
        {
            foreach (var item in sorteiosSelecionados)
            {
                SqlConnection conn = new SqlConnection(conecta);
                string sqlQuery = "INSERT INTO TabelaDivDois(idTabelaDivDoisSorteio)" +
                                  " VALUES (@idSorteio)";
                SqlCommand comando = new SqlCommand(sqlQuery, conn);
                comando.Parameters.Add(new SqlParameter("@idSorteio", item.idSorteio));

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
            }
            return null;
        }

        internal TabelaDivDois ExcluirTabelaDivDois()
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "DELETE FROM TabelaDivDois;" +
                               " DBCC CHECKIDENT('TabelaDivDois', RESEED, 0)";
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

        internal List<TabelaDivDois> GerarTabelaDiv2()
        {
            List<TabelaDivDois> lstTabelaDivDois = new List<TabelaDivDois>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT tdu.idTabelaDivDois, tdu.idTabelaDivDoisSorteio, u.idUsuario, u.nomeUsuario, u.emailUsuario, t.idTime, t.time, s.divisao" +
                               " FROM TabelaDivDois AS tdu" +
                               " INNER JOIN Sorteio AS s ON s.idSorteio = tdu.idTabelaDivDoisSorteio" +
                               " INNER JOIN Usuario AS u ON u.idUsuario = s.idSorteioUsuario" +
                               " INNER JOIN Time AS t ON t.idTime = s.idSorteioTime";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TabelaDivDois tabelaDivDois = new TabelaDivDois();
                Sorteio sorteio = new Sorteio();
                Usuario usuario = new Usuario();
                Time time = new Time();
                tabelaDivDois.idTabelaDivDois = Convert.ToInt32(dr["idTabelaDivDois"].ToString());
                tabelaDivDois.idTabelaDivDoisSorteio = Convert.ToInt32(dr["idTabelaDivDoisSorteio"].ToString());
                usuario.idUsuario = Convert.ToInt32(dr["idUsuario"].ToString());
                tabelaDivDois.usuario.idUsuario = usuario.idUsuario;
                usuario.nomeUsuario = dr["nomeUsuario"].ToString();
                tabelaDivDois.usuario.nomeUsuario = usuario.nomeUsuario;
                usuario.emailUsuario = dr["emailUsuario"].ToString();
                tabelaDivDois.usuario.emailUsuario = usuario.emailUsuario;
                time.idTime = Convert.ToInt32(dr["idTime"].ToString());
                tabelaDivDois.time.idTime = time.idTime;
                time.time = dr["time"].ToString();
                tabelaDivDois.time.time = time.time;
                sorteio.divisao = Convert.ToInt32(dr["divisao"].ToString());
                tabelaDivDois.sorteio.divisao = sorteio.divisao;

                lstTabelaDivDois.Add(tabelaDivDois);
            }
            conn.Close();

            return lstTabelaDivDois;
        }        
    }
}
