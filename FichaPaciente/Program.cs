using System;
using FichaPaciente;


namespace FichaPaciente
{
    class Program
    {
        static void Main(string[] args)
        {
            Acesso usuarioAcesso = new Acesso("Lana", "13A");

            Console.Write("Digite o nome do usuário: ");
            string nomeDoUsuario = Console.ReadLine();

            Console.Write("Digite a senha do usuário: ");
            string senhaDoUsuario = Console.ReadLine();

            if (!usuarioAcesso.ValidarLogin(nomeDoUsuario, senhaDoUsuario))
            {
                Console.WriteLine("Login ou Senha inválidos, por favor, revise e tente novamente");
                return;
            }
            else
            {
                Console.WriteLine("Aguarde....");


            }
            Console.Clear();
            Console.WriteLine();
            Console.Write("Nome do Paciente: ");
            string nome = Console.ReadLine();

            Console.Write("Idade do Paciente: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Diagnóstico do Paciente: ");
            string diagnostico = Console.ReadLine();

            Paciente pac = new Paciente(nome, idade, diagnostico);
            Console.WriteLine();
            Console.WriteLine("----------Ficha Médica----------");
            Console.WriteLine();
            Console.WriteLine(pac);
        }


        }


    }





