using ExemplosExplorando.Models;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {

        int numero = 20;
        bool par = false;

        par = numero.ehPar();



        // var deserialize= File.ReadAllText("Arquivos/vendas.json");

        // List<Vendas> listaVendas = JsonConvert.DeserializeObject<List<Vendas>>(deserialize);

        // var listaAnonimia = listaVendas.Select(x => new { x.Id, x.NomeProduto });

        // foreach(var i in listaAnonimia)
        // {
        //     System.Console.WriteLine(i.Id.ToString(), i.NomeProduto);
        // }

        // foreach(var v in listaVendas)
        // {
        //     System.Console.WriteLine($"{v.Id} {v.NomeProduto} {v.Preco.ToString("C")} {v.DataVenda.ToString("dd-MM-yy HH:mm")}");
        // }
        // DateTime dataVenda = DateTime.Now;
        // List<Vendas> listaVendas = new();

        // Vendas v1 = new(1, "Caderno", 23.00M,dataVenda);
        // Vendas v2 = new(1, "Lapis", 3.00M, dataVenda);

        // listaVendas.Add(v1);
        // listaVendas.Add(v2);


        // string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

        // File.WriteAllText("Arquivos/vendas.json", serializado);

        // System.Console.WriteLine(serializado);


        // LeituraArquivo leituraArquivo = new();
        //     string caminho = "Arquivos/arquivoLeitura.txt";
        //     var (sucesso, linhasAquivos, quantidade) = leituraArquivo.LerArquivo(caminho);

        //     if (sucesso)
        //     {
        //         System.Console.WriteLine("Quantidade de linhas" + linhasAquivos.Count());
        //         foreach (var i in linhasAquivos)
        //         {
        //             System.Console.WriteLine(i);
        //         }
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Nao foi possivel ler o arquivos");
        //     }













        // (int id, string nome, string sobrenome) tupla = (1, "a", "b");
        // var tupla2 = Tuple.Create(1, "a", "b");
        // ValueTuple<int, string, string> tupla3 = (1, "a", "b");


        //         Queue<int> fifo = new();
        //         Stack<int> lifo = new();

        //         fifo.Enqueue(1);
        //          fifo.Enqueue(2);
        //           fifo.Enqueue(3);
        //            fifo.Enqueue(4);
        //             fifo.Enqueue(5);
        //         lifo.Push(1);
        //          lifo.Push(2);
        //           lifo.Push(3);
        //            lifo.Push(4);
        //             lifo.Push(5);


        //    foreach(var i in fifo)
        //    {
        //     System.Console.WriteLine(i);
        //    }

        //    foreach(var i in lifo)
        //    {
        //     System.Console.WriteLine(i);
    }

    private static Vendas New()
    {
        throw new NotImplementedException();
    }

    // try
    // {

    // string[] linhas = File.ReadAllLines("Arquivos/arquivooLeitura.txt");

    // foreach(var l in linhas)
    // {
    //     System.Console.WriteLine(l);
    // }
    // }catch(FileNotFoundException e)
    // {   
    //     System.Console.WriteLine($"Arquivo nao encontrado :{e.Message}");
    // }
    // catch(DirectoryNotFoundException e)
    // {   
    //     System.Console.WriteLine($"Caminho do arquivo nao encontrado :{e.Message}");
    // }
    // catch(Exception e)
    // {   
    //     System.Console.WriteLine($"Erro encontrado :{e.Message}");
    // } finally
    // {
    //     System.Console.WriteLine("Chegou ate aqui");
    // }



    // Pessoa p1 = new Pessoa(nome: "Carlos", sobrenome: "Antonio", idade: 28);
    // Pessoa p2 = new Pessoa(nome: "Marcella", sobrenome: "GOzzi", idade: 35);


    // Curso cursoDeIngles = new();
    // cursoDeIngles.NomeCurso = "Curso de Ingles";
    // cursoDeIngles.AdicionarAlunos(p1);
    // cursoDeIngles.AdicionarAlunos(p2);
    // cursoDeIngles.ListarAlunos();


    // DateTime data = DateTime.Now;
    // System.Console.WriteLine(data.ToString("dd-MM-yyyy HH:mm"));
    // decimal d = 1345.0909M;
    // System.Console.WriteLine(d.ToString("N3"));

}
