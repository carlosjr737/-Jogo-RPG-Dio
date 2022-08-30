// See https://aka.ms/new-console-template for more information

using ExemploConstrutores.Models;

Pessoa pessoa = Pessoa.GetInstace();

pessoa.PropriedaPessoa = "teste";

System.Console.WriteLine(pessoa.PropriedaPessoa);

Pessoa p1 = Pessoa.GetInstace();
System.Console.WriteLine(pessoa.PropriedaPessoa);


