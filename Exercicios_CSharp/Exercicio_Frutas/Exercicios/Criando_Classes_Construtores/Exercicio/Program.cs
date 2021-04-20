using Exercicio1_Classes_Construtores;
using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Receita chocolate = new Receita();
            chocolate.nome = "Bolo de chocolate";
            chocolate.tamanho = "Pequeno";
            chocolate.peso = 1.5;
            chocolate.preco = 20.00;

            Receita morango = new Receita();
            morango.nome = "Bolo de morango";
            morango.tamanho = "Médio";
            morango.peso = 2.0;
            morango.preco = 30.00;

            Receita abacaxi = new Receita();
            abacaxi.nome = "Bolo de abacaxi";
            abacaxi.tamanho = "Grande";
            abacaxi.peso = 3.0;
            abacaxi.preco = 40.00;

            Carro veiculo = new Carro();
            veiculo.marca = "TOYOTA";
            veiculo.modelo = "COROLA";
            veiculo.cor = "AZUL";
            veiculo.valorFipe = 45000.00;

            Televisão aparelho = new Televisão();
            aparelho.marca = "AOC";
            aparelho.tamanho = "50 Polegadas";
            aparelho.preço = 2800.00;
            aparelho.caracteristica = "Ultra HD";


            Animal animal = new Animal();
            animal.nome = "Cachoro";
            animal.sexo = "Masculino";
            animal.tipo = "Pastor alemã";


        }
    }
}
