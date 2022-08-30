using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemplosExplorando.Models
{
    public class Vendas
    {

        public Vendas(int id, string nomeProduto, decimal preco, DateTime dataVenda)
        {
            Id = id;
            NomeProduto = nomeProduto;
            Preco = preco;
            DataVenda = dataVenda;
        }

        public int Id { get; set; }
        [JsonProperty("")]
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        
        }
    }
