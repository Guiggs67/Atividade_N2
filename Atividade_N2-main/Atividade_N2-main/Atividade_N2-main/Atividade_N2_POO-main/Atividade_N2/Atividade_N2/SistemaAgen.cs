using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_N2
{
    internal class SistemaAgen: Agendamento
    {

        SistemaClien clien;
        public List<Agendamento> agend = new List<Agendamento>();

        public SistemaAgen(SistemaClien clien)
        {
            this.clien = clien;
        }

        public void Agendar()
        {
            string nome;
            Console.WriteLine("Digite o nome do cliente");
            nome = Console.ReadLine();
            
            foreach (Cliente clie1 in clien.clie)
            {
                

                if (nome== clie1.Nome)
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
                        

                        agend.Add(new Agendamento());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Formato inválido");
                    }
                }

                else
                {
                    Console.WriteLine("Cliente não existe");
                   
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
            foreach (Cliente clie1 in clien.clie)
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
