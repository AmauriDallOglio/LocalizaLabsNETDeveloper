using Polly.Retry;

namespace Vaquinha.Service.Interface
{
    public interface IPollyService
    {
        AsyncRetryPolicy CriarPoliticaWaitAndRetryPara(string method);
    }
}
