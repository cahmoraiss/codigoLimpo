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

        public string[] valoresAteNove  = { "zero", "um","dois", "tres", "quatro", "cinco", "seis", "sete", "oito", "nove"};
        public string[] valoresAteDezenove = { "dez", "onze", "doze", "treze", "quatroze", "quinze", "dezeseis", "dezesete", "dezoito", "dezenove" };
        public string[] valoresDecimais = { "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };

        public ConverterValor()
        {
        }
        
        public string retornarValorExtenso(double valor)
        {
            switch(valor.ToString().Length)
            {
                case 1:
                    valorPorExtenso = valoresAteNove[(int)valor];
                    break;
                case 2:
                    if (valor < 20)
                    {
                        valorPorExtenso = valoresAteDezenove[(int)valor-10];
                    }
                    else
                    {
                        valorPorExtenso = valoresDecimais[(int)valor];
                    }
                    break;
            }

            return valorPorExtenso;
        }

     
    }
}
