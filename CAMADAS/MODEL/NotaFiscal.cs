using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Thay_and_Lusca.CAMADAS.MODEL
{
    public class NotaFiscal
    {
        public int id { get; set; }

        public Cliente cliente { get; set; }

        public DateTime data { get; set; }


    }
}
