﻿using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO USUARIO(Nome, NomeUsuario, Senha, Ativo)VALUES(@Nome, @NomeUsuario, @Senha, @Ativo)";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);

                cn.Open();

                cmd.ExecuteNonQuery();                                                 
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar inserir o usuario no banco de dados ", ex);
            }
        }
        public void Alterar(Usuario _usuario)
        {

        }
        public void Excluir(int _id)
        {

        }
        public List<Usuario> BuscarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
