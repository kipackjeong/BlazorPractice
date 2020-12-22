using RESTFulSense.Clients;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPracticeServer.Brokers.Api
{
    public partial class ApiBroker : IApiBroker
    {
        private IRESTFulApiFactoryClient _apiClient;

        public ApiBroker(IRESTFulApiFactoryClient apiClient) => _apiClient = apiClient;

        private async ValueTask<IEnumerable<T>> GetAllAsync<T>(string relativeUrl) =>
            await this._apiClient.GetContentAsync<IEnumerable<T>>(relativeUrl);

        private async ValueTask<T> GetAsync<T>(string relativeUrl) =>
            await this._apiClient.GetContentAsync<T>(relativeUrl);

        private async ValueTask<T> PostAsync<T>(string relativeUrl, T content) =>
            await this._apiClient.PostContentAsync<T>(relativeUrl, content);

        private async ValueTask<T> PutAsync<T>(string relativeUrl, T content) =>
            await this._apiClient.PutContentAsync<T>(relativeUrl, content);

        private async ValueTask<T> DeleteAsync<T>(string relativeUrl) =>
            await this._apiClient.DeleteContentAsync<T>(relativeUrl);

    }
}
