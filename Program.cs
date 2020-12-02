using System;
using cadastro_de_alunos.classe;

namespace cadastro_de_alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Vamos desenvolver um programa que cadastre e mostre um aluno. Criando uma classe aluno com as seguintes
            propriedades: Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. Também teremos os métodos: VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.*/

            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            aluno.nome = Console.ReadLine();

            Console.WriteLine("Digite o curso do aluno: ");
            aluno.curso = Console.ReadLine();
            
            Console.WriteLine("Digite o RG do aluno: ");
            aluno.rg = Console.ReadLine();
            
            Console.WriteLine("Digite a idade do aluno: ");
            aluno.idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a média final do aluno: ");
            aluno.mediaFinal = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da mensalidade: ");
            aluno.valorMensalidade = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite se o aluno é bolsista: s/n?");
            string resposta = Console.ReadLine();

            if (resposta == "s")
            {
                aluno.bolsista = true;
            }else{
                aluno.bolsista = false;
            }
            
            // menu

            int opcao = 0;

            do
            {
                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("Opção [1] - Ver média do aluno");
                Console.WriteLine("Opção [2] - Ver mensalidade do aluno");
                Console.WriteLine("Opção [3] - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"A média final do {aluno.nome} = {aluno.VerMediaAluno()}");
                        break;
                    case 2:
                        Console.WriteLine($"O valor da mensalidade do aluno fica em: {aluno.VerMensalidade()}");
                        break;
                    case 0:
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
                



            } while (opcao != 0);

            
            
        }
    }
}
