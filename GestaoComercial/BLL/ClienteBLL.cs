using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteBLL
    {
        public void Inserir(Cliente _cliente)
        {
            if (string.IsNullOrEmpty(_cliente.Nome))
                throw new Exception("Informe o nome do usuario.");
            new ClienteDAL().Inserir(_cliente);
        }
        public void Alterar(Cliente _cliente)
        {
            new ClienteDAL().Alterar(_cliente);
        }
        public void Excluir(int _id)
        {
            new ClienteDAL().Excluir(_id);
        }
        public List<Cliente> BuscarTodos()
        {
            return new ClienteDAL().BuscarTodos();
        }
        public Cliente BuscarPorId(int _id)
        {
            return new ClienteDAL().BuscarPorId(_id);
        }
        public List<Cliente> BuscarPorNome(string _nome)
        {
            return new ClienteDAL().BuscarPorNome(_nome);
        }
        public List<Cliente> BuscarPorTelefone(string _fone)
        {
            return new ClienteDAL().BuscarPorTelefone(_fone);
        }

    }
}




