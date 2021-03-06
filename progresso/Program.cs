﻿using System;
using System.Globalization;

namespace progresso {
    class Program {
        static void Main(string[] args) {

            //Innicia-se criando um novo número de quartos, sendo 10.
            Quarto[] vet = new Quarto[10];

            //Perguntamos quantos quartos a pessoa irá alugar naquele momento.
            Console.WriteLine("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());
            //Atribuimos esse número à variavel "n"

                for (int i = 0; i < n; i++) {
                //Utilizamos ele para criar os quartos e preencher os atributos de cada um
                    Console.WriteLine("Digite o nome do enquilino: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite o email do enquilino: ");
                    string email =Console.ReadLine();
                    Console.WriteLine("Selecione o quarto que deseja entre (quarto número 0 e quarto número 9)");
                //Aqui é selecionado o número do quarto que a pessoa deseja, usamos ele para criar o quarto na posição do vetor.
                    int quarto = int.Parse(Console.ReadLine());
                    vet[quarto] = new Quarto(nome, email);

                }
                //Assim que os quartos forão criados mostro eles para a pessoa
            Console.WriteLine("Aqui está a lista de quartos ocupados até o momento:");
            for (int i = 0; i < 10; i++) {
                //Checo todas as posições do vetor, e todas aquelas que tiverem preenchidas alguma coisa, mostro ela na tela, em formato de lista.
                if (vet[i] != null) {
                    Console.WriteLine(i + ": " + vet[i]);
                    
                }
            }  

        }
    }
}
