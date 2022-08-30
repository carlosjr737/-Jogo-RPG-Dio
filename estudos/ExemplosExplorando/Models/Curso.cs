using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class Curso
    {
        public string? NomeCurso { get; set; }
        public List<Pessoa> Alunos = new List<Pessoa>();

        public void AdicionarAlunos(Pessoa aluno)

        {
            if(aluno == null)
            {
                throw new ArgumentException("Aluno null");
            }
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos!.Remove(aluno);
        
        }

        public void ListarAlunos()
        {   
            System.Console.WriteLine($"Alunos do {NomeCurso}");

            for (var contador = 0; contador < Alunos.Count; contador++)
            {
                string texto =  $"N {contador +1} - {Alunos[contador].NomeCompleto}";
                System.Console.WriteLine(texto);
            }

        }
    }
}