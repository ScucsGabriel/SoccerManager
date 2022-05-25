using SoccerManager.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace SoccerManager.DAO
{
    class TabelaDivUmDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal TabelaDivUm InserirTabelaDivUm(List<Sorteio> sorteiosSelecionados)
        {
            foreach (var item in sorteiosSelecionados)
            {
                SqlConnection conn = new SqlConnection(conecta);
                string sqlQuery = "INSERT INTO TabelaDivUm(idTabelaDivUmSorteio)" +
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
        internal TabelaDivUm ExcluirTabelaDivUm()
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "DELETE FROM TabelaDivUm;" +
                               " DBCC CHECKIDENT('TabelaDivUm', RESEED, 0)";
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

        internal List<TabelaDivUm> GerarTabelaDiv1()
        {
            List<TabelaDivUm> lstTabelaDivUm = new List<TabelaDivUm>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT tdu.idTabelaDivUm, tdu.idTabelaDivUmSorteio, u.idUsuario, u.nomeUsuario, u.emailUsuario, t.idTime, t.time, s.divisao" +
                               " FROM TabelaDivUm AS tdu" +
                               " INNER JOIN Sorteio AS s ON s.idSorteio = tdu.idTabelaDivUmSorteio" +
                               " INNER JOIN Usuario AS u ON u.idUsuario = s.idSorteioUsuario" +
                               " INNER JOIN Time AS t ON t.idTime = s.idSorteioTime";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TabelaDivUm tabelaDivUm = new TabelaDivUm();
                Sorteio sorteio = new Sorteio();
                Usuario usuario = new Usuario();
                Time time = new Time();
                tabelaDivUm.idTabelaDivUm = Convert.ToInt32(dr["idTabelaDivUm"].ToString());
                tabelaDivUm.idTabelaDivUmSorteio = Convert.ToInt32(dr["idTabelaDivUmSorteio"].ToString());
                usuario.idUsuario = Convert.ToInt32(dr["idUsuario"].ToString());
                tabelaDivUm.usuario.idUsuario = usuario.idUsuario;
                usuario.nomeUsuario = dr["nomeUsuario"].ToString();
                tabelaDivUm.usuario.nomeUsuario =  usuario.nomeUsuario;
                usuario.emailUsuario = dr["emailUsuario"].ToString();
                tabelaDivUm.usuario.emailUsuario = usuario.emailUsuario;
                time.idTime = Convert.ToInt32(dr["idTime"].ToString());
                tabelaDivUm.time.idTime = time.idTime;
                time.time = dr["time"].ToString();
                tabelaDivUm.time.time = time.time;
                sorteio.divisao = Convert.ToInt32(dr["divisao"].ToString());
                tabelaDivUm.sorteio.divisao = sorteio.divisao;

                lstTabelaDivUm.Add(tabelaDivUm);
            }
            conn.Close();

            return lstTabelaDivUm;
        }              
    }
}
