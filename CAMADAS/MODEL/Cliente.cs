using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Thay_and_Lusca.CAMADAS.MODEL
{
    public class Cliente
    {
        public int id { get; set; }

        public string usuario { get; set; }

        public string senha { get; set; }

        public string nome { get; set; }

        public string endereco { get; set; }

        public float saldo { get; set; }

        public int vip { get; set; }
    }
}
