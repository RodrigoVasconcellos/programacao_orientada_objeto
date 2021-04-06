using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Frutas
{
    public class Alunos
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public int Media { get; set; }

        public int[] Nota { get; set; }

        public Alunos()
        {
            this.Nota = new int[2];
        }
        public int CalculaMedia(int[] notas)
        {
            var soma_total = 0;
            var media = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                soma_total += notas[i];
               
            }
            media = (soma_total / notas.Length);
            return media;
        }        

    }
}

