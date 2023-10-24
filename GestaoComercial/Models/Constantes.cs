using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Constantes
    {
        private static string stringDeConexao = "User ID=SA;Initial Catalog=Mercearia;Data Source=.\\SQLEXPRESS2019A;Password=Senailab02";

        public static string StringDeConexao
        {
            get { return stringDeConexao; }
        }


    }
    
}
