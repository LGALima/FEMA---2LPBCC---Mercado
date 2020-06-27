using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Thay_and_Lusca.CAMADAS.MODEL
{
    public class RegistroCompra
    {
        public int id { get; set; }


        public DateTime data { get; set; }

        public float totalPago { get; set; }

        public int idCliente { get; set; }
    }
}
