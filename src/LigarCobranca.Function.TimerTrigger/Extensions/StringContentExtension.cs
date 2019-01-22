using System.Net.Http;
using System.Text;

namespace LigarCobranca.Function.TimerTrigger.Extensions
{
    public class StringContentExtension : StringContent
    {
        public StringContentExtension(string content)
            : base(content, Encoding.UTF8, "application/json") { }
    }
}