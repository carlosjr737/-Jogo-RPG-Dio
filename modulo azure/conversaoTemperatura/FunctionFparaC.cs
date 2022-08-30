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
    public class FunctionFparaC
    {
        private readonly ILogger<FunctionFparaC> _logger;

        public FunctionFparaC(ILogger<FunctionFparaC> log)
        {
            _logger = log;
        }

        [FunctionName("FunctionFparaC")]
        [OpenApiOperation(operationId: "Run", tags: new[] { "Conversao" })]
        [OpenApiParameter(name: "f", In = ParameterLocation.Path, Required = true, Type = typeof(double), Description = "O valor em  **F** PARA C ")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(string), Description = "O Valor em c")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get",  Route = "ConverterFparaC/{f}")] HttpRequest req,
            double f
            )
        {
            _logger.LogInformation($"Paramentro recebido{f}", f);


            var valorC = (f - 32) * 5 / 9;

            string responseMessage = $"O valor {f} convertido em C e {valorC}";

            _logger.LogInformation($"Conversao efetuada com sucesso. resultado {valorC}");

            return new OkObjectResult(responseMessage);
        }
    }
}

