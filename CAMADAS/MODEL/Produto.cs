﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Thay_and_Lusca.CAMADAS.MODEL
{
    // Modelo mapeado de produtos
    public class Produto
    {
        public int id { get; set; }

        public string produto { get; set; }

        public int idCategoria { get; set; }

        public int quantidadeEstoque { get; set; }

        public float preco { get; set; }

        public string imagem { get; set; }
    }
}
