using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_N2
{
    internal class Agendamento : Cliente
    {
        string Nome_barbearia { get; set; }
        DateTime Data { get; set; }
        string Horario { get; set; }
        string Local { get; set; }

        List<Agendamento> agend = new List<Agendamento>();
        public Agendamento(string nome_barbearia, DateTime data, string local)
        {
            Nome_barbearia = nome_barbearia;
            Data = data;
            Local = local;
        }
        public Agendamento() 
        {

        }

        public void Agendar()
        {
            string nome;
            Console.WriteLine("Digite o nome do cliente");
            nome = Console.ReadLine();
            foreach (Cliente clie1 in clie)
            {
                if (clie1.Nome == nome)
                {
                    try
                    {
                        Console.WriteLine("Digite o nome da barbearia");
                        Nome_barbearia = Console.ReadLine();
                        Console.WriteLine("Digite a data do agendamento");
                        Data = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o horário");
                        Horario = (Console.ReadLine());
                        Console.WriteLine("Digite o local");
                        Local = (Console.ReadLine());
                    }catch (Exception ex)
                    {
                        Console.WriteLine("Formato inválido");
                    }
                    break;
                }

                else
                {
                    Console.WriteLine("Cliente não existe");
                    break;
                }
            }

        }
        public void Desmarcar()
        {

            agend.Clear();
        }

        public void Consultar3()
        {
                string nome;
                Console.WriteLine("Digite o nome do cliente");
                nome = Console.ReadLine();
            foreach (Cliente clie1 in clie)
            {
                if (nome == clie1.Nome)
                {
                    Console.WriteLine(Nome);
                    Console.WriteLine(Nome_barbearia);
                    Console.WriteLine(Data);
                    Console.WriteLine(Horario);
                    Console.WriteLine(Local);
                }
            }
        }
    }



}
