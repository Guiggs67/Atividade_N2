using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_N2
{
    internal class Agendamento : Cliente
    {
        public string Nome_barbearia { get; set; }
        public DateTime Data { get; set; }
        public string Horario { get; set; }
        public string Local { get; set; }
   
        public Agendamento(string nome_barbearia, DateTime data, string local)
        {
            Nome_barbearia = nome_barbearia;
            Data = data;
            Local = local;
    
        }
        public Agendamento() 
        {

        }

        
    }



}
