using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhandoComArquivos.Helper
{
    public class FileHelper
    {
        
        public void ListarDiretorios(string caminho){
        var resultadoCaminho = Directory.GetDirectories(caminho);

        foreach(var resultado in caminho)
            {
                System.Console.WriteLine(caminho);
            }
        }
        
    }
}