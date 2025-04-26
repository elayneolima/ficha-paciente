using System;
using FichaPaciente;

Console.Write("Nome do Paciente: "); 
string nome  = Console.ReadLine();

Console.Write("Idade do Paciente: ");
int idade = int.Parse(Console.ReadLine());

Console.Write("Diagnóstico do Paciente: "); 
string diagnostico = Console.ReadLine();

Paciente pac = new Paciente(nome, idade, diagnostico);
Console.WriteLine();
Console.WriteLine("----------Ficha Médica----------");
Console.WriteLine();
Console.WriteLine(pac); 