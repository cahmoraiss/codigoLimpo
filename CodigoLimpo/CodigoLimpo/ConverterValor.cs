using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoLimpo
{
    public class ConverterValor
    {
        private string valorPorExtenso;

        public ConverterValor()
        {
        }

        public string ConverterValorPorExtenso(decimal valor)
        {            
            if (valor == 1)
            {
                valorPorExtenso = "Um real";                
            }
            return valorPorExtenso;
        }        
    }
}
