using SoccerManager.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.DAO
{
    class UsuarioDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal Usuario InserirUsuario(string nomeUsuario, string emailUsuario, string telefoneUsuario, string usuarioAtivo)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlQuery = "INSERT INTO Usuario(nomeUsuario, emailUsuario, telefoneUsuario, usuarioAtivo)" +
                " VALUES (@nomeUsuario, @emailUsuario, @telefoneUsuario, @usuarioAtivo)";
            SqlCommand comando = new SqlCommand(sqlQuery, conn);
            comando.Parameters.Add(new SqlParameter("@nomeUsuario", nomeUsuario));
            comando.Parameters.Add(new SqlParameter("@telefoneUsuario", telefoneUsuario));
            comando.Parameters.Add(new SqlParameter("@emailUsuario", emailUsuario));
            comando.Parameters.Add(new SqlParameter("@usuarioAtivo", usuarioAtivo));

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

        internal List<Usuario> ConsultarTodoUsuarioAtivo()
        {
            List<Usuario> lstUsuario = new List<Usuario>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Usuario WHERE usuarioAtivo = 'Sim' ORDER BY nomeUsuario";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Usuario usuario = new Usuario();
                usuario.idUsuario = Convert.ToInt32(dr["idUsuario"].ToString());
                usuario.nomeUsuario = dr["nomeUsuario"].ToString();
                usuario.emailUsuario = dr["emailUsuario"].ToString();
                usuario.telefoneUsuario = dr["telefoneUsuario"].ToString();
                usuario.usuarioAtivo = dr["usuarioAtivo"].ToString();

                lstUsuario.Add(usuario);
            }
            conn.Close();

            return lstUsuario;
        }
        internal List<Usuario> ConsultarTodoUsuario()
        {
            List<Usuario> lstUsuario = new List<Usuario>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Usuario";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Usuario usuario = new Usuario();
                usuario.idUsuario = Convert.ToInt32(dr["idUsuario"].ToString());
                usuario.nomeUsuario = dr["nomeUsuario"].ToString();
                usuario.emailUsuario = dr["emailUsuario"].ToString();
                usuario.telefoneUsuario = dr["telefoneUsuario"].ToString();
                usuario.usuarioAtivo = dr["usuarioAtivo"].ToString();

                lstUsuario.Add(usuario);
            }
            conn.Close();

            return lstUsuario;
        }

        internal List<Usuario> ConsultarUsuarioPorId(int idUsuario)
        {
            List<Usuario> lstUsuario = new List<Usuario>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Usuario WHERE idUsuario = " + idUsuario + "AND usuarioAtivo = 'Sim'";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Usuario usuario = new Usuario();
                usuario.idUsuario = Convert.ToInt32(dr["idUsuario"].ToString());
                usuario.nomeUsuario = dr["nomeUsuario"].ToString();
                usuario.emailUsuario = dr["emailUsuario"].ToString();
                usuario.telefoneUsuario = dr["telefoneUsuario"].ToString();
                usuario.usuarioAtivo = dr["usuarioAtivo"].ToString();

                lstUsuario.Add(usuario);
            }
            conn.Close();

            return lstUsuario;
        }

        internal List<Usuario> ConsultarUsuarioPorNome(string nomeUsuario)
        {
            List<Usuario> lstUsuario = new List<Usuario>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Usuario WHERE usuarioAtivo = 'Sim'" +
                               " AND (nomeUsuario LIKE '%" + nomeUsuario + "%')" +
                               " ORDER BY nomeUsuario";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Usuario usuario = new Usuario();
                usuario.idUsuario = Convert.ToInt32(dr["idUsuario"].ToString());
                usuario.nomeUsuario = dr["nomeUsuario"].ToString();
                usuario.emailUsuario = dr["emailUsuario"].ToString();
                usuario.telefoneUsuario = dr["telefoneUsuario"].ToString();
                usuario.usuarioAtivo = dr["usuarioAtivo"].ToString();

                lstUsuario.Add(usuario);
            }
            conn.Close();

            return lstUsuario;
        }

        internal List<Usuario> ConsultarUsuarioPorEmail(string emailUsuario)
        {
            List<Usuario> lstUsuario = new List<Usuario>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Usuario WHERE emailUsuario like '%" + emailUsuario + "%' " +
                               " AND usuarioAtivo = 'Sim' ORDER BY emailUsuario";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Usuario usuario = new Usuario();
                usuario.idUsuario = Convert.ToInt32(dr["idUsuario"].ToString());
                usuario.nomeUsuario = dr["nomeUsuario"].ToString();
                usuario.emailUsuario = dr["emailUsuario"].ToString();
                usuario.telefoneUsuario = dr["telefoneUsuario"].ToString();
                usuario.usuarioAtivo = dr["usuarioAtivo"].ToString();

                lstUsuario.Add(usuario);
            }
            conn.Close();

            return lstUsuario;
        }

        internal Usuario ExcluirUsuario(int idUsuario)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "UPDATE Usuario SET usuarioAtivo = 'Não'" +
                               " WHERE idUsuario = " + idUsuario;
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

        internal List<Usuario> EditarUsuario(int idUsuario, string nomeUsuario, string emailUsuario, string telefoneUsuario, string usuarioAtivo)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "UPDATE Usuario SET nomeUsuario = @nomeUsuario, emailUsuario = @emailUsuario, telefoneUsuario = @telefoneUsuario, usuarioAtivo = @usuarioAtivo" +
                               " WHERE idUsuario = " + idUsuario;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            cmd.Parameters.Add(new SqlParameter("@nomeUsuario", nomeUsuario));
            cmd.Parameters.Add(new SqlParameter("@emailUsuario", emailUsuario));
            cmd.Parameters.Add(new SqlParameter("@telefoneUsuario", telefoneUsuario));
            cmd.Parameters.Add(new SqlParameter("@usuarioAtivo", usuarioAtivo));

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
