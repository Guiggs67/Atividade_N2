using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_N2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SistemaClien cli = new SistemaClien();
            SistemaFunc func = new SistemaFunc();
            SistemaAgen ag = new SistemaAgen();

            int opcoes;
            int opc;
        
            do
            {
                Console.WriteLine("Digite uma opção");
                Console.WriteLine("1-Cliente");
                Console.WriteLine("2-Funcionário");
                Console.WriteLine("3-Agendamento");
                Console.WriteLine("4-Finalizar o programa");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        do
                        {
                        Console.WriteLine("Tela do cliente");
                        Console.WriteLine("----------------");
                        Console.WriteLine("Digite sua opção:");
                        Console.WriteLine("1-Cadastro");
                        Console.WriteLine("2-Consultar");
                        Console.WriteLine("3-Excluir");
                        Console.WriteLine("4-Alterar");
                        Console.WriteLine("5-Sair");
                        opcoes = int.Parse(Console.ReadLine());
                        
                            switch (opcoes)
                            {
                                case 1:
                                    cli.Cadastrar1();
                                    break;
                                case 2:
                                    cli.Consultar1();
                                    break;
                                case 3:
                                    cli.Excluir();
                                    break;
                                case 4:
                                    cli.Alterar();
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    break;
                            }
                        } while (opcoes != 5);
                        break;

                    case 2:
                        do
                        {
                        Console.WriteLine("Tela do funcionário");
                        Console.WriteLine("----------------");
                        Console.WriteLine("Digite sua opção:");
                        Console.WriteLine("1-Cadastro");
                        Console.WriteLine("2-Consultar");
                        Console.WriteLine("3-Demitir");
                        Console.WriteLine("4-Sair");
                        opcoes = int.Parse(Console.ReadLine());
         
                        switch (opcoes)
                        {
                            case 1:
                                func.Cadastrar();
                                break;
                            case 2:
                                func.Consultar();
                                break;
                            case 3:
                                func.Demitir();
                                break;
                            default:
                                Console.WriteLine("Opção inválida");
                                break;
                        }
                        }while (opcoes != 5);
                        break;

                    case 3:
                     do { 
                        Console.WriteLine("Tela de Agendamento");
                        Console.WriteLine("----------------");
                        Console.WriteLine("Digite sua opção:");
                        Console.WriteLine("1-Cadastro");
                        Console.WriteLine("2-Desmarcar");
                        Console.WriteLine("3-Consultar");
                        Console.WriteLine("4-Sair");
                        opcoes = int.Parse(Console.ReadLine());
                        switch (opcoes)
                        {
                            case 1:
                                ag.Agendar();
                                break;
                            case 2:
                                ag.Desmarcar();
                                break;
                            case 3:
                                ag.Consultar3();
                                break;
                            default:
                                Console.WriteLine("Opção inválida");
                                break;
                        }
                        } while (opcoes != 5);
                        break;
                }
            } while (opc != 4);

            Console.WriteLine("Obrigado :)");
            Console.ReadKey();
        }
    }
}
