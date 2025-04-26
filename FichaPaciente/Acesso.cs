using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaPaciente
{
    internal class Acesso
    {
        public string Usuario;
        public string Senha;

        public Acesso(string usuario, string senha)
        {
            this.Usuario = usuario;
            this.Senha = senha;
        }

        public bool ValidarLogin(string usuarioNome, string usuarioSenha)
        {
            return usuarioNome == Usuario && usuarioSenha == Senha;
        } 

        
    }
}
