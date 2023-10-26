
using DAL;
using Models;
using System.Data.SqlClient;

namespace BLL
{
    public class ProdutoBLL
    {
        public void Inserir(Produto _produto)
        {
            if (string.IsNullOrEmpty(_produto.Nome))
                throw new Exception("Informe o nome do usuario.");
            new ProdutoDAL().Inserir(_produto);
        }
        public void Alterar(Produto _produto)
        {
            new ProdutoDAL().Alterar(_produto);
        }
        public void Excluir(int _id)
        {
            new ProdutoDAL().Excluir(_id);
        }
        public List<Produto> BuscarTodos()
        {
            return new ProdutoDAL().BuscarTodos();
        }
        public Produto BuscarPorId(int _id)
        {
            return new ProdutoDAL().BuscarPorId(_id);
        }
        public List<Produto> BuscarPorNome(string _nome)
        {
            return new ProdutoDAL().BuscarPorNome(_nome);
        }
        public Produto BuscarPorCodigoDeBarra(string _codigoBarra)
        {
            return new ProdutoDAL().BuscarPorCodigoDeBarra(_codigoBarra);
        }
    }
}



