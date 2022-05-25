using SoccerManager.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace SoccerManager.DAO
{
    class TimeDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal Time InserirTime(string time, string timeAtivo)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlQuery = "INSERT INTO Time(time, timeAtivo)" +
                              " VALUES (@time, @timeAtivo)";
            SqlCommand comando = new SqlCommand(sqlQuery, conn);
            comando.Parameters.Add(new SqlParameter("@time", time));
            comando.Parameters.Add(new SqlParameter("@timeAtivo", timeAtivo));

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

        internal List<Time> ConsultarTodoTimeAtivo()
        {
            List<Time> lstTime = new List<Time>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Time WHERE timeAtivo = 'Sim' ORDER BY time";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Time time = new Time();
                time.idTime = Convert.ToInt32(dr["idTime"].ToString());
                time.time = dr["time"].ToString();
                time.timeAtivo = dr["TimeAtivo"].ToString();

                lstTime.Add(time);
            }
            conn.Close();

            return lstTime;
        }
        internal List<Time> ConsultarTodoTime()
        {
            List<Time> lstTime = new List<Time>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Time WHERE timeAtivo = 'Sim' ORDER BY time";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Time time = new Time();
                time.idTime = Convert.ToInt32(dr["idTime"].ToString());
                time.time = dr["time"].ToString();
                time.timeAtivo = dr["TimeAtivo"].ToString();

                lstTime.Add(time);
            }
            conn.Close();

            return lstTime;
        }

        internal List<Time> ConsultarTimePorId(int idTime)
        {
            List<Time> lstTime = new List<Time>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Time WHERE idTime = " + idTime + " AND timeAtivo = 'Sim'";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Time time = new Time();
                time.idTime = Convert.ToInt32(dr["idTime"].ToString());
                time.time = dr["time"].ToString();
                time.timeAtivo = dr["TimeAtivo"].ToString();

                lstTime.Add(time);
            }
            conn.Close();

            return lstTime;
        }

        internal List<Time> ConsultarTime(string time)
        {
            List<Time> lstTime = new List<Time>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Time WHERE time like '%" + time + "%' " +
                               " AND timeAtivo = 'Sim' ORDER BY time";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Time times = new Time();
                times.idTime = Convert.ToInt32(dr["idTime"].ToString());
                times.time = dr["time"].ToString();
                times.timeAtivo = dr["TimeAtivo"].ToString();

                lstTime.Add(times);
            }
            conn.Close();

            return lstTime;
        }
        internal Time ExcluirTime(int idTime)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "UPDATE Time SET timeAtivo = 'Não' WHERE idTime = " + idTime;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            cmd.Parameters.Add(new SqlParameter("@idTime", idTime));

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

        internal List<Time> EditarTime(int idTime, string time, string timeAtivo)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "Update Time Set time = @time, timeAtivo = @timeAtivo" +
                               " WHERE idTime = " + idTime;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            cmd.Parameters.Add(new SqlParameter("@time", time));
            cmd.Parameters.Add(new SqlParameter("@timeAtivo", timeAtivo));

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um problema na edição de dados: " + ex);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }
    }
}