using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Mvc;

namespace azureBlogStorage.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class ArquivoController : ControllerBase
    {
        private readonly string _connectionString;
        private readonly string _containerName;

        public ArquivoController(IConfiguration configuration)
        {
            _connectionString = configuration.GetValue<string>("BlobConnectionString");
            _containerName = configuration.GetValue<string>("BlobContainerName");
        }

        [HttpPost]
        public IActionResult UploadArquivo(IFormFile arquivo)
        {
            BlobContainerClient container = new(_connectionString, _containerName);
            BlobClient blob = container.GetBlobClient(arquivo.FileName);

            using var data = arquivo.OpenReadStream();
            blob.Upload(data, new BlobUploadOptions
            {
                HttpHeaders = new BlobHttpHeaders{ ContentType = arquivo.ContentType}
            });
            return Ok(blob.Uri.ToString());

        }

        [HttpGet("Downloads/{nome}")]
        public IActionResult DownloadArquivo(string nome)
        {
            BlobContainerClient container = new(_connectionString, _containerName);
            BlobClient blob = container.GetBlobClient(nome);

            if(!blob.Exists()) return BadRequest();

            var retorno = blob.DownloadContent();
            return File(retorno.Value.Content.ToArray(), retorno.Value.Details.ContentType, blob.Name);
        }

        [HttpDelete("ApagarArquivo/{nome}")]
        public IActionResult ApagarArquivo(string nome)
        {
            BlobContainerClient container = new(_connectionString, _containerName);
            BlobClient blob = container.GetBlobClient(nome);

            blob.DeleteIfExists();
            return NoContent();
        }

        [HttpGet("Listar")]
        public IActionResult ListarBlobs()
        {
            List<BlobDto> ListBlobs = new ();
            BlobContainerClient container = new(_connectionString, _containerName);
            
            foreach (var blob in container.GetBlobs())
            {
                ListBlobs.Add(new BlobDto
                    {
                    Nome = blob.Name,
                    Tipo = blob.Properties.ContentType,
                    Uri = container.Uri.AbsoluteUri + "/" + blob.Name
                    }
                );
            }

            return Ok(ListBlobs);
        }
    }
}