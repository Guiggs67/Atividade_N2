using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_N2
{
    class Cliente
    {
        public string Nome { get; set;}
        public DateTime Nascimento { get; set; }
        public string Endereco { get; set; }

        public List<Cliente> clie = new List<Cliente>();
        public Cliente(string nome, DateTime nascimento, string endereco)
        {
            Nome = nome;
            Nascimento = nascimento;
            Endereco = endereco;
        }

        public Cliente() 
        { 
        
        }

        public void Cadastrar1()
        {
            try
            {
                Console.WriteLine("Insira o nome do cliente");
                Nome = Console.ReadLine();
                Console.WriteLine("Insira o nascimento do cliente");
                Nascimento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Insira o endereço do cliente");
                Endereco = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Formato inválido");
            }

            clie.Add(new Cliente(Nome, Nascimento, Endereco));
        }

        public void Consultar1()
        {
            string cliente;
            Console.WriteLine("Insira o nome do cliente");
            cliente = Console.ReadLine();
            if (cliente == Nome)
            {
                Console.WriteLine(Nome);
                Console.WriteLine(Nascimento);
                Console.WriteLine(Endereco);
            }
            else
            {
                Console.WriteLine("Cliente inexistente.");
            }
        }

        public void Excluir()
        {
            clie.Clear();

        }
        public void Alterar() 
        { 
            clie.Clear();

            Console.WriteLine("Insira o nome do cliente");
            Nome = Console.ReadLine();
            Console.WriteLine("Insira o nascimento do cliente");
            Nascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Insira o endereço do cliente");
            Endereco = Console.ReadLine();

            clie.Add(new Cliente(Nome, Nascimento, Endereco));
        }
    }
}
