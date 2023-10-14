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

        public void Cadastrar()
        {
            try
            {
                Console.WriteLine("Insira o nome do funcionário");
                Nome_func = Console.ReadLine();
                Console.WriteLine("Insira o nascimento do funcionário");
                Especialidade = Console.ReadLine();
                Console.WriteLine("Insira o endereço do funcionário");
                Codigo = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Formato inválido");
            }
            func.Add(new Funcionario(Nome_func, Especialidade, Codigo));
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
                Console.WriteLine(Codigo);
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
