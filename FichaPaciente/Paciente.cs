using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaPaciente
{
    internal class Paciente
    {
        public string Nome;
        public int Idade;
        public string Diagnostico; 


        public Paciente(string nome, int idade, string diagnostico)
        {
            this.Nome = nome;  
            this.Idade = idade;
            this.Diagnostico = diagnostico;
        }

        public override string ToString()
        {
            return "Nome: "
                   + this.Nome 
                   + "\n"
                   + "Idade: "
                   + this.Idade
                   +"\n"
                   +"Diagnóstico:"
                   + this.Diagnostico;
        }
    }
   
    

    

}
