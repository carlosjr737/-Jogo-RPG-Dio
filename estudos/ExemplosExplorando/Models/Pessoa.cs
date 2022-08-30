using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class Pessoa
    {
        
        private string? _nome;
        private int? _idade;

        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }


        public string? Nome 
        { 
            get
            {
                return _nome;
            }
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("Nome nao pode ser  vazio");
                }
                _nome = value!;
            }
        }
        public string? Sobrenome { get; set; }
        public string? NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int? Idade 
        {
            get => _idade;
            set
            {
                if(value <0)
                {
                    throw new ArgumentException("Idade nao pode ser menor do que 0");
                }
                _idade = value;
            } 
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Nome:{NomeCompleto}, Idade: {Idade}");
        }
    }
}