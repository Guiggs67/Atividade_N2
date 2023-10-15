using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_N2
{
   public class Funcionario
    {
        public string Nome_func { get; set;}
        public string Especialidade{ get; set; }
       


        public Funcionario(string nome_func, string especialidade)
        {
            Nome_func = nome_func;
            Especialidade = especialidade;
        }
        public Funcionario()
        {

        }

        
    }
}
