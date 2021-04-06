using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Frutas
{
    public class Frutas
    {
        public string Nome { get; set; }
        public int Valor { get; set; }

        public int SomaValor (int valor1, int valor2)
        {
            var somaTotal = 0;
            somaTotal = valor1 + valor2;

            return somaTotal;
        }
    }


}
