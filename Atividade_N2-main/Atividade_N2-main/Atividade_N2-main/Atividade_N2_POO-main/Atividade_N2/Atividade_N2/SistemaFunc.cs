using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_N2
{
    internal class SistemaFunc:Funcionario
    {
        public List<Funcionario> func = new List<Funcionario>();
        //Usando encapsulamento
        private int cod;

        public int Cod
        {
            get
            {
                return cod;
            }
            set
            {
                Random rnd = new Random();
                cod = rnd.Next(1, 100);
            }
        }

        public void Cadastrar()
        {
            try
            {
                Console.WriteLine("Insira o nome do funcionário");
                Nome_func = Console.ReadLine();
                Console.WriteLine("Insira o nascimento do funcionário");
                Especialidade = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Formato inválido");
            }
            func.Add(new Funcionario(Nome_func, Especialidade));
        }

        public void Consultar()
        {
            string funcionario;
            Console.WriteLine("Insira o nome do funcionário");
            funcionario = Console.ReadLine();
            if (funcionario == Nome_func)
            {
                Console.WriteLine(Nome_func);
                Console.WriteLine(Especialidade);
                Console.WriteLine(Cod);
            }
            else
            {
                Console.WriteLine("Funcinário não encontrado");
            }
        }

        public void Demitir()
        {
            func.Clear();
        }
    }
}
