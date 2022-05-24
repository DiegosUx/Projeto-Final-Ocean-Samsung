using System;
using FuncionamentoElevador.classes;

namespace FuncionamentoElevador
{
    class Program
    {
        static void Main(string[] args) 

            //Primeira entrada do Elevador, se apresentando ao usuario e anexando a classe criada
        {
            Elevador elevador = new Elevador();
            Console.WriteLine("Bem vindo a Stark Tower, como você não é um vingador seu acesso esta liberado somente até o terceiro Andar.");
            Console.WriteLine();
            elevador.TotalDeAndares = 3;
            elevador.Inicializa(elevador.Capacidade, elevador.TotalDeAndares);
            bool opcao = true;
            
            //Aqui  foi criada uma estrutura de repetição para pedir ao usuário escolha uma opção
            
            do
            {
                Console.WriteLine("1 <- Adicionar Pessoa");
                Console.WriteLine("2 <- Remover Pessoa");
                Console.WriteLine("3 <- Subir um andar");
                Console.WriteLine("4 <- Descer um andar");
                Console.WriteLine("0 <- Sair");
                string opcao1 = Console.ReadLine();
                
                //comando exlusivamente para limpar a tela do console
                Console.Clear();
                
                //Opções do Usuario
                switch (opcao1)
                {
                    case "1":
                        Console.WriteLine(elevador.Entrar(elevador.Capacidade));
                        break;
                    case "2":
                        Console.WriteLine(elevador.Sair());
                        break;
                    case "3":
                        Console.WriteLine(elevador.Subir(elevador.TotalDeAndares));
                        break;
                    case "4":
                        Console.WriteLine(elevador.Descer(elevador.TotalDeAndares));
                        break;
                    case "0":
                        Console.WriteLine("Obrigado por visitar a Stark Tower!");
                        opcao = false;
                        break;
                    default:
                        Console.WriteLine("Digite um valor valido");
                        break;
                }
                //Enquando for diferente de falso, repetir a ação.
            } while (opcao != false);
        }
    }
}