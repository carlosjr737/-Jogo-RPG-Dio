using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Azure.Data.Tables;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webApiAzureTable.Models;

namespace webApiAzureTable.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly string _connectionString;
        private readonly string _tableName;

        public ContatoController(IConfiguration config)
        {
            _connectionString = config.GetValue<string>("SAConnectionString");
            _tableName = config.GetValue<string>("AzureTableName");
        }

        private TableClient GetTableClient()    
        {
            var serviceClient = new TableServiceClient(_connectionString);
            var tableClient = serviceClient.GetTableClient(_tableName);

            tableClient.CreateIfNotExists();
            return tableClient; 
        }

        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            var tableClient = GetTableClient();

            contato.RowKey = Guid.NewGuid().ToString();
            contato.PartitionKey = contato.RowKey;

            tableClient.UpsertEntity(contato);

            return Ok(contato);
        }

        [HttpPut("id")]
        public IActionResult Atualizar(string id, Contato contato)
        {
            var tableClient = GetTableClient();
            var contatoTable = tableClient.GetEntity<Contato>(id, id).Value;

            contatoTable.Name = contato.Name;
            contatoTable.Email = contato.Email;
            contatoTable.Telefone = contato.Telefone;

            tableClient.UpsertEntity(contatoTable);
            return Ok();

        }   

        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos()
        {
            var tableClient = GetTableClient();
            var contatos = tableClient.Query<Contato>().ToList();

            return Ok(contatos);
        }

        [HttpGet("ObterPorNome/{nome}")]
        public IActionResult ObterPorNome(string nome)
        {
            var tableClient = GetTableClient();
            var contatos = tableClient.Query<Contato>(x=> x.Name == nome).ToList();

            return Ok(contatos);
        }

        [HttpDelete("{id}")]
        public IActionResult Deleter(string id)
        {
            var tableClient = GetTableClient();
            tableClient.DeleteEntity(id, id);

            return NoContent();
        }
    }
}