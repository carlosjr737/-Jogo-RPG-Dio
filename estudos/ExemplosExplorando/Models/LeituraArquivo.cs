using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class LeituraArquivo
    {
        public (bool sucess,string[] listaLinhas,int quantidaLinhas) LerArquivo(string caminho)
        {
            try
            {
            string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());

            }
            catch(Exception e)
            {
                return (false, new string[0], 0);
            }
        }
    }
}