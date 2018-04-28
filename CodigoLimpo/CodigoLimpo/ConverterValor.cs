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
        public enum enmValores
        {
            Zero = 0,
            Um,
            Dois,
            Tres,
            Quatro,
            Cinco,
            Seis,
            Sete,
            Oito,
            Nove,
            Dez,
            Onze,
            Doze,
            Treze,
            Quatroze,
            Quinze,
            Dezesseis,
            Dezesete,
            Dezoite,
            Dezenove
            
        }

        public string[] valores  = { "zero", "um", "tres", "quatro"};
        

        public ConverterValor()
        {
        }
        
        public void blah(double valor)
        {
            switch(valor.ToString().Length)
            {
                case 1:
                    valorPorExtenso = valores[(int)valor];
                    break;


            }
            

        }

     
    }
}
