using LigarCobranca.Function.TimerTrigger.Models;
using LigarCobranca.Function.TimerTrigger.Service;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LigarCobranca.Function.TimerTrigger
{
    public static class LigarCobrancaFunction
    {
        private static readonly string _telefonesIndesejados = Environment.GetEnvironmentVariable("TelefoneIndesejados", EnvironmentVariableTarget.Process);
        private static readonly string _bina = Environment.GetEnvironmentVariable("Bina", EnvironmentVariableTarget.Process);

        [FunctionName("LigarCobrancaTimerTrigger")]
        public static async Task Run([TimerTrigger("0 */1 * * * *")]TimerInfo myTimer, TraceWriter log)
        {
            log.Info($"Function executada: {DateTime.Now}");

            foreach (var telefoneIndesejado in _telefonesIndesejados.Split(',').ToList())
            {
                var compostoModel = new CompostoModel
                {
                    NumeroDestino = telefoneIndesejado,
                    Dados = new List<CompostoDadosModel>
                    {
                        new CompostoDadosModel
                        {
                            Acao = "tts",
                            AcaoDados = new AcaoDadosModel
                            {
                                Mensagem = "Você irá receber ligações infinitamente, até que pare de ligar no meu número!",
                                Velocidade = "-4",
                                RespostaUsuario = "true",
                                TipoVoz = "br-Ricardo"
                            }
                        }
                    },
                    Bina = _bina
                };

                await CompostoService.PostCompostoAsync(compostoModel);
            }

            log.Info($"Function encerrada: {DateTime.Now}");
        }
    }
}