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

        public string ConverterValorPorExtenso(double valor)
        {            
            if (valor >= 1 && valor <= 9)
            {
                switch (valor.ToString())
                {
                    case "1":
                        valorPorExtenso = "um";
                    break;
                    case "2":
                        valorPorExtenso = "dois";
                    break;
                    }                    
            }
            return valorPorExtenso;
        }        
    }
}
