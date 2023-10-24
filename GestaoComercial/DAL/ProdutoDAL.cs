
using Models;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace DAL
{
    public class ProdutoDAL
    {
        public void Inserir(Produto _produto)
        {
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO PRODUTO(Id, Nome, Preco, Estoque)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _produto.Id);
                cmd.Parameters.AddWithValue("@Nome", _produto.Nome);
                cmd.Parameters.AddWithValue("@Preco", _produto.Preco);
                cmd.Parameters.AddWithValue("Estoque", _produto.Estoque);

                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir o produto no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
            public void Alterar(Produto _produto)
            {
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            try

            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPADATE PRODUTO SET = Id, Nome, Preco, Estoque";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _produto.Id);
                cmd.Parameters.AddWithValue("@Nome", _produto.Nome);
                cmd.Parameters.AddWithValue("@Preco", _produto.Preco);
                cmd.Parameters.AddWithValue("Estoque", _produto.Estoque);

                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar o produto no banco de dados");
            }
            finally
            {
                cn.Close();
            }

            }
            public void Excluir(int _id)
            {
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "DELETE FROM PRODUTO WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("id", _id);

                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir o produto no bano de dados");
            }
            finally
            {
                cn.Close();
            }


            }
            public List<Produto> BuscarTodos()
            {
            List<Produto> produtoList = new List<Produto>();
            Produto produto;
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT Id, Nome, Preco, Estoque";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        produto = new Produto();
                        produto.Id = (int)rd["Id"];
                        produto.Nome = rd["Nome"].ToString();
                        produto.Preco = Convert.ToDouble(rd["Preco"]);
                        produto.Estoque = (int)rd["Estoque"];
                        produtoList.Add(produto);

                    }
                    return produtoList;

                }
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar novos usuarios");

            }
            finally
            {
                cn.Close();
            }

            {

            }

            }

        public Produto BuscarPorId(int _id)
        {
            Produto produto;

            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT Id, Nome, Preco, Estoque FROM PRODUTO";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    produto = new Produto();
                    if (rd.Read())
                    {
                        produto.Id = (int)rd["Id"];
                        produto.Nome = rd["Nome"].ToString();
                        produto.Preco = Convert.ToDouble(rd["Preco"]);
                        produto.Estoque = (int)rd["Estoque"];
                    }
                    return produto;
                }




            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar novos usuarios");
            }
            finally
            {
                cn.Close();
            }

        }

         


    }
}

