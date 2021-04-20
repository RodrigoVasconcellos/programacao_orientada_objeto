using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Classes_Construtores
{
    class Receita
    {
        public Receita(string nome = "" )
        {
            this.nome = nome;
        }
        //public Receita() { }
        public string nome { get; set; }
        public string tamanho { get; set; }
        public double peso { get; set; }
        public double preco { get; set; }
        

        public void salvar() 
        {
        }

        public void mostrar()
        {
        }

    }
}
