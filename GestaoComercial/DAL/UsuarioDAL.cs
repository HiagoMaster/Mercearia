using Models;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario, SqlTransaction transaction = null)
        {
            

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {

                using (SqlCommand cmd = new SqlCommand("INSERT INTO USUARIO(Nome, NomeUsuario, Senha, Ativo)VALUES(@Nome, @NomeUsuario, @Senha, @Ativo)"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                        cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                        cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                        cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);

                        if (transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }
                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.ExecuteNonQuery();

                        if (transaction == null)
                            transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        if (transaction.Connection != null && transaction.Connection.State == ConnectionState.Open)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar inserir o usuario no banco de dados ", ex);
                    }


                }

            }

        }
        public void Alterar(Usuario _usuario, SqlTransaction transaction = null)
        {
           using SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
           
           using(SqlCommand cmd = new SqlCommand("UPDATE USUARIO SET Nome = @Nome, NomeUsuario = @NomeUsuario, Senha = @Senha, Ativo = @Ativo, WHERE id = @id"))
            {

            
            try
            {
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);

                if(transaction == null)
                {
                        cn.Open();
                        transaction = cn.BeginTransaction();
                }
                    cmd.Transaction = transaction;
                    cmd.Connection = transaction.Connection;

                    cmd.ExecuteNonQuery();

                    if (transaction == null)
                        transaction.Commit();

            }
            catch (Exception ex)
            {
                    if (transaction.Connection != null && transaction.Connection.State == ConnectionState.Open)
                        transaction.Rollback();
                    throw new Exception("Ocorreu um erro ao tentar alterar o usuario no banco de dados ", ex);
            }
           }
        }







        public void Excluir(int _id, SqlTransaction transaction = null)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            using (SqlCommand cmd = new SqlCommand("DELETE FROM USUARIO WHERE id = @id"))
            {

                try
                {

                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("id", _id);
                    if(transaction == null)
                    {
                        cn.Open();
                        transaction = cn.BeginTransaction();
                    }

                    cmd.Transaction = transaction;
                    cmd.Connection = transaction.Connection;

                    cmd.ExecuteNonQuery();

                    if (transaction == null)
                        transaction.Commit();




                }
                catch (Exception ex)
                {
                    if (transaction.Connection != null && transaction.Connection.State == ConnectionState.Open)
                        transaction.Rollback();
                    throw new Exception("Ocorreu um erro ao tentar exlcuir o usuario no banco de dados ", ex);
                }
               
            }
        }


        public List<Usuario> BuscarTodos()
        {
            List<Usuario> usuarioList = new List<Usuario>();
            Usuario usuario;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT Id, Nome, NomeUsuario, Senha, Ativo FROM Usuario";
                cmd.CommandType = System.Data.CommandType.Text;
            
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = (int)rd["Id"];
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        usuarioList.Add(usuario);

                    }
                    return usuarioList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar novos usuarios ");
            }
            finally
            {
                cn.Close();
            }
        }

        public Usuario BuscarPorId(int _id)
        {

            
            Usuario usuario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT Id, Nome, NomeUsuario, Senha, Ativo FROM Usuario WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {

                    usuario = new Usuario();
                    if (rd.Read())
                    {
                        usuario.Id = (int)rd["Id"];
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        

                    }
                    return usuario;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar novos usuarios ");
            }
            finally
            {
                cn.Close();
            }
        }

        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            Usuario usuario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT Id, Nome, NomeUsuario, Senha, Ativo FROM Usuario WHERE NomeUsuario = @NomeUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@NomeUsuario", _nomeUsuario);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {

                    usuario = new Usuario();
                    if (rd.Read())
                    {
                        usuario.Id = (int)rd["Id"];
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);


                    }
                    return usuario;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar novos usuarios ");
            }
            finally
            {
                cn.Close();
            }


        }

        public List<Usuario> BuscarPorNome(string _nome)
        {
            List<Usuario> usuarioList = new List<Usuario>();
            Usuario usuario;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"SELECT Id, Nome, NomeUsuario, Senha, Ativo FROM Usuario WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = PreencherObjeto(rd);
                        usuarioList.Add(usuario);

                    }
                    return usuarioList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar usuario por nome no banco de dados");
            }
            finally
            {
                cn.Close();
            }


        }

        private static Usuario PreencherObjeto(SqlDataReader rd)
        {
            Usuario usuario = new Usuario();
            usuario.Id = (int)rd["Id"];
            usuario.Nome = rd["Nome"].ToString();
            usuario.NomeUsuario = rd["NomeUsuario"].ToString();
            usuario.Senha = rd["Senha"].ToString();
            usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
            return usuario;
        }
    }
}


