using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Thay_and_Lusca.CAMADAS.MODEL
{
    public class Compra
    {
        public NotaFiscal NotaFiscal { get; set; }

        public Produto produto { get; set; }

        public int quantidade { get; set; }

        public float valorBruto { get; set; }

        public float desconto { get; set; }

        public float valorPago { get; set; }
    }
}
