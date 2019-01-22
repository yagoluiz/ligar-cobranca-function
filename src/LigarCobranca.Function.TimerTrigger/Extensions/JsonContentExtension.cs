using Newtonsoft.Json;

namespace LigarCobranca.Function.TimerTrigger.Extensions
{
    public class JsonContentExtension
    {
        public static string JsonSerialize(object json)
        {
            return JsonConvert.SerializeObject(json, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}