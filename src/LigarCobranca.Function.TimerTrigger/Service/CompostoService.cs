using LigarCobranca.Function.TimerTrigger.Client;
using LigarCobranca.Function.TimerTrigger.Extensions;
using LigarCobranca.Function.TimerTrigger.Models;
using System.Threading.Tasks;

namespace LigarCobranca.Function.TimerTrigger.Service
{
    public static class CompostoService
    {
        public static async Task PostCompostoAsync(CompostoModel compostoModel)
        {
            var response = await HttpClientCommon.TotalVoice.PostAsync($"composto",
                new StringContentExtension(JsonContentExtension.JsonSerialize(compostoModel)));

            var stringResponse = await response.Content.ReadAsStringAsync();
            
        }
    }
}