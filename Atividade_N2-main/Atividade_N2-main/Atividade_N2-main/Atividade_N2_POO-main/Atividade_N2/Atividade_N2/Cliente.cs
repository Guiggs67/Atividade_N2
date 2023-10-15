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
       

        public Cliente(string nome, DateTime nascimento, string endereco)
        {
            Nome = nome;
            Nascimento = nascimento;
            Endereco = endereco;
            
        }

        public Cliente() 
        {
           
        }

        
    }
}
