using System;
using System.Collections.Generic;

namespace Exercicio_Frutas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EXERCÍCIO ALUNO MÉDIA*/

            List<Alunos> alunos = new List<Alunos>();
            Alunos um_aluno = new Alunos();
            var numero_alunos = 0;
            var soma_total = 0;

            Console.WriteLine("Digite qtd de alunos");
            numero_alunos = Convert.ToInt32 (Console.ReadLine());

            for (int i = 0; i < numero_alunos; i++)
            {
                um_aluno = new Alunos();
                Console.WriteLine("Digite o nome do aluno");
                um_aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite a matricula do aluno");
                um_aluno.Matricula = Console.ReadLine();

                for (int n = 0; n < 2; n++)
                {
                    Console.WriteLine("Digite o valor aluno");
                    um_aluno.Nota[n] = Convert.ToInt32(Console.ReadLine());

                }

                um_aluno.Media = um_aluno.CalculaMedia(um_aluno.Nota);
                alunos.Add(um_aluno);

            }

            foreach (var item in alunos)
            {
                Console.WriteLine("Nome do aluno: " + item.Nome);
                for (int i = 0; i < item.Nota.Length; i++)
                {
                    Console.WriteLine("Nota: " + item.Nota[i]); 
                    
                }
                for (int a = 0; a < item.Nota.Length; a++)
                {
                    soma_total += item.Nota[a];                    
                }
                Console.WriteLine("Soma das notas: " + soma_total);
                Console.WriteLine("Media: " + item.Media);                
            }
        }

        public void CalculaFrutas()
        {
            ///*EXERCÍCIO FRUTAS*/
            var somaValor = 0;
            List<Frutas> listaDeFrutas = new List<Frutas>();
            Frutas umaFruta = new Frutas();

            for (int i = 0; i < 2; i++)
            {
                umaFruta = new Frutas();
                Console.WriteLine("Digite o nome da fruta");
                umaFruta.Nome = Console.ReadLine();
                Console.WriteLine("Digite o valor da fruta");
                umaFruta.Valor = Convert.ToInt32(Console.ReadLine());

                listaDeFrutas.Add(umaFruta);
            }

            var valor = listaDeFrutas[1].Valor;

            somaValor = umaFruta.SomaValor(listaDeFrutas[0].Valor, listaDeFrutas[1].Valor);
            Console.WriteLine("Valor da soma das frutas é:" + somaValor);

        }

    }
}
