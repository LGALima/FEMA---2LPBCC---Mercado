﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Thay_and_Lusca.Relatórios
{
    public class Funcoes
    {
        public static string diretorioPasta()
        {
            string pasta = @"C:\Facul\dotNet\FEMA---2LPBCC---Mercado\Relatórios";
            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);
            return pasta;
        }
    }
}
