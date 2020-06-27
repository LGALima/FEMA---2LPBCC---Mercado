using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Thay_and_Lusca.CAMADAS.MODEL
{
    public class Compra
    {
        public int id { get; set; }

        public int idCliente { get; set; }

        public int idProduto { get; set; }

        public int idRegistroCompra { get; set; }

        public int quantidade { get; set; }

        public float total { get; set; }
    }
}
