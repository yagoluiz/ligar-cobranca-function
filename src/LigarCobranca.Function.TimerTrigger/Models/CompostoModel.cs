using Newtonsoft.Json;
using System.Collections.Generic;

namespace LigarCobranca.Function.TimerTrigger.Models
{
    public class CompostoModel
    {
        [JsonProperty("numero_destino")]
        public string NumeroDestino { get; set; }

        [JsonProperty("dados")]
        public IEnumerable<CompostoDadosModel> Dados { get; set; }

        [JsonProperty("bina")]
        public string Bina { get; set; }

        [JsonProperty("gravar_audio")]
        public bool? GravarAudio { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }
    }

    public class CompostoDadosModel
    {
        [JsonProperty("acao")]
        public string Acao { get; set; }

        [JsonProperty("acao_dados")]
        public AcaoDadosModel AcaoDados { get; set; }
    }

    public class AcaoDadosModel
    {
        [JsonProperty("mensagem")]
        public string Mensagem { get; set; }

        [JsonProperty("velocidade")]
        public string Velocidade { get; set; }

        [JsonProperty("resposta_usuario")]
        public string RespostaUsuario { get; set; }

        [JsonProperty("tipo_voz")]
        public string TipoVoz { get; set; }
    }
}