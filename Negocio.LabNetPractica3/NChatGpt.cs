using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenAI_API;
using OpenAI_API.Completions;

namespace Negocio.LabNetPractica3
{
   public class NChatGpt : INChatGpt
    {
        public async Task<string> Responder(string pregunta)
        {
            string apiKey = "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";
            string respuesta = "";

            var openAi = new OpenAIAPI(apiKey);
            CompletionRequest completion = new CompletionRequest();
            completion.Prompt = pregunta;
            completion.Model = "text-davinci-003";
            completion.Temperature = 0.5;
            completion.MaxTokens = 4000;

            var resultado = await openAi.Completions.CreateCompletionAsync(completion);

            if (respuesta != null) {
                foreach (var item in resultado.Completions)
                {
                    respuesta = item.Text;
                }
            }
            return respuesta;
        }
    }
}
