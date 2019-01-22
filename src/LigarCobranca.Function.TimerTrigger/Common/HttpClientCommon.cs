using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace LigarCobranca.Function.TimerTrigger.Client
{
    public static class HttpClientCommon
    {
        private static HttpClient _httpClient;
        private static readonly string _totalVoiceAPI = Environment.GetEnvironmentVariable("TotalVoiceAPI", EnvironmentVariableTarget.Process);
        private static readonly string _totalVoiceToken = Environment.GetEnvironmentVariable("TotalVoiceToken", EnvironmentVariableTarget.Process);

        public static HttpClient TotalVoice
        {
            get
            {
                if (_httpClient == null)
                {
                    _httpClient = new HttpClient();
                    _httpClient.BaseAddress = new Uri(_totalVoiceAPI);
                    _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    _httpClient.DefaultRequestHeaders.Add("Access-Token", _totalVoiceToken);
                }

                return _httpClient;
            }
        }
    }
}