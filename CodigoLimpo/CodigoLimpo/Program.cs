using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoLimpo
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 10;
            string valorExtenso;
            ConverterValor converterValor = new ConverterValor();

            valorExtenso = converterValor.retornarValorExtenso(valor);
        }

        
    }
}
