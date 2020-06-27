using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Thay_and_Lusca.CAMADAS.DAL
{
    public class Conexao
    {
        public static string getConexao()
        {
            return @"Data Source=.\sqlexpress;Initial Catalog=MERCADINHO;Integrated Security=True";
        }

        public static string getPathImagens()
        {
            return @"C:\Tudo\Fema\2020\almir\06-29 - Trabalho .net mercadin\IMAGENS\";
        }
    }
}
