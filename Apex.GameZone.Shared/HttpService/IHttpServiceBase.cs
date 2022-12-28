using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apex.GameZone.Shared.HttpService
{
    public interface IHttpServiceBase
    {
        string UrlPath { get; set; }

        /// <summary>
        /// Makes requests to LynxData
        /// </summary>
        /// <typeparam name="TRequest">Request Type</typeparam>
        /// <typeparam name="TResponse">Response Type</typeparam>
        /// <param name="httpMethod">Request type </param>
        /// <param name="accessToken">JWT Bearer token</param>
        /// <param name="queryPath">Query url</param>
        /// <param name="model">Model that needs to be passed</param>
        /// <returns></returns>
        Task<TResponse> HttpRequest<TRequest, TResponse>(HttpMethod httpMethod, string accessToken, string queryPath, TRequest model);
        Task<Stream> HttpStreamRequest<TRequest>(HttpMethod httpMethod, string accessToken, string queryPath, TRequest model);

    }
}
