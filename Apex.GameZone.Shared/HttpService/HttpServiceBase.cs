using Apex.GameZone.Shared.Helper;
using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;
using System.Text;

namespace Apex.GameZone.Shared.HttpService
{
    public abstract class HttpServiceBase : IHttpServiceBase
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<HttpServiceBase> _logger;


        protected HttpServiceBase(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public abstract string UrlPath { get; set; }

        public async Task<TResponse> HttpRequest<TRequest, TResponse>(HttpMethod httpMethod, string accessToken, string queryPath, TRequest model)
        {
            string httpResult = "";


            var authenticationHeaderValue = HttpHelper.AuthenticationHeaderValueBuilder(accessToken);

            var json = JsonHelper.SerializeToJsonString(model);
            httpResult = await HttpClientRequestData(httpMethod, authenticationHeaderValue, queryPath, json, CancellationToken.None);

            return JsonHelper.JsonDeserializeToModel<TResponse>(httpResult);
        }

        public async Task<Stream> HttpStreamRequest<TRequest>(HttpMethod httpMethod, string accessToken, string queryPath, TRequest model)
        {
            var authenticationHeaderValue = HttpHelper.AuthenticationHeaderValueBuilder(accessToken);

            var json = JsonHelper.SerializeToJsonString(model);
            var httpResult = await HttpClientRequestStreamData(httpMethod, authenticationHeaderValue, queryPath, json, CancellationToken.None);

            return httpResult;
        }

        public string BuildUrlParam(string url, string urlParam)
            => string.IsNullOrWhiteSpace(urlParam) ? url : string.Format(url, urlParam);

        public string BuildQueryParam(string url, string queryParam)
            => string.IsNullOrWhiteSpace(queryParam) ? url : url + $"?{queryParam}";

        #region Private functions/methods
        private async Task<string> HttpClientRequestData(HttpMethod httpMethod, AuthenticationHeaderValue authenticationHeaderValue, string queryPath, string data, CancellationToken cancellationToken)
        {
            if (authenticationHeaderValue != null)
                _httpClient.DefaultRequestHeaders.Authorization = authenticationHeaderValue;

            HttpResponseMessage response = null;
            queryPath = $"{(string.IsNullOrWhiteSpace(UrlPath) ? "" : $"{UrlPath}/")}{queryPath}";

            try
            {
                if (httpMethod == HttpMethod.Get)
                {
                    response = await _httpClient.GetAsync(queryPath, cancellationToken);
                }
                else if (httpMethod == HttpMethod.Post)
                {
                    response = await _httpClient.PostAsync(queryPath, ConvertToHttpContent(data), cancellationToken);
                }
                else if (httpMethod == HttpMethod.Put)
                {
                    response = await _httpClient.PutAsync(queryPath, ConvertToHttpContent(data), cancellationToken);
                }
                else if (httpMethod == HttpMethod.Patch)
                {
                    response = await _httpClient.PatchAsync(queryPath, ConvertToHttpContent(data), cancellationToken);
                }
                else if (httpMethod == HttpMethod.Delete)
                {
                    var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, queryPath)
                    {
                        Content = ConvertToHttpContent(data)
                    };
                    response = await _httpClient.SendAsync(httpRequestMessage, cancellationToken);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            await ThrowIfUnsuccessfulAsync(response);

            var result = response != null ? await response.Content.ReadAsStringAsync() : null;
            return result;
        }

        private async Task<Stream> HttpClientRequestStreamData(HttpMethod httpMethod, AuthenticationHeaderValue authenticationHeaderValue, string queryPath, string data, CancellationToken cancellationToken)
        {
            if (authenticationHeaderValue != null)
                _httpClient.DefaultRequestHeaders.Authorization = authenticationHeaderValue;

            HttpResponseMessage response = null;
            queryPath = $"{(string.IsNullOrWhiteSpace(UrlPath) ? "" : $"{UrlPath}/")}{queryPath}";

            if (httpMethod == HttpMethod.Get)
            {
                response = await _httpClient.GetAsync(queryPath, cancellationToken);
            }
            else if (httpMethod == HttpMethod.Post)
            {
                response = await _httpClient.PostAsync(queryPath, ConvertToHttpContent(data), cancellationToken);
            }
            else if (httpMethod == HttpMethod.Put)
            {
                response = await _httpClient.PutAsync(queryPath, ConvertToHttpContent(data), cancellationToken);
            }

            await ThrowIfUnsuccessfulAsync(response);

            var result = response != null ? await response.Content.ReadAsStreamAsync() : null;

            return result;
        }

        private HttpContent ConvertToHttpContent(string json)
        {
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return content;
        }

        private async Task ThrowIfUnsuccessfulAsync(HttpResponseMessage message)
        {
            if (!message.IsSuccessStatusCode)
            {
                switch (message.StatusCode)
                {
                    case System.Net.HttpStatusCode.Unauthorized:
                        throw new UnauthorizedAccessException();
                }

                await using var stream = await message.Content.ReadAsStreamAsync();
                using var document = await System.Text.Json.JsonDocument.ParseAsync(stream);
                var json = document.RootElement;

                throw null;
            }
        }

        #endregion
    }
}
