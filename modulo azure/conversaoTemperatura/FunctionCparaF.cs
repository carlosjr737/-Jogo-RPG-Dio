using System.IO;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

namespace ConversaoTemperatura
{
    public class FunctionCparaF
    {
        private readonly ILogger<FunctionCparaF>_logger;

        public FunctionCparaF(ILogger<FunctionCparaF> log)
        {
            _logger = log;
        }

        [FunctionName("FunctionCparaF")]
        [OpenApiOperation(operationId: "Run", tags: new[] { "Conversao" })]
        [OpenApiParameter(name: "c", In = ParameterLocation.Path, Required = true, Type = typeof(double), Description = "O valor em  **C** PARA F ")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(string), Description = "O Valor em F")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get",  Route = "ConverterFparaC/{c}")] HttpRequest req,
            double c
            )
        {
            _logger.LogInformation($"Paramentro recebido{c}", c);


        var valorF = (c * 9) / 5 + 32;

        string responseMessage = $"O valor {c} convertido em C e {valorF}";

            _logger.LogInformation($"Conversao efetuada com sucesso. resultado {valorF}");

            return new OkObjectResult(responseMessage);
        }
    }
}

