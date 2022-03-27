using RequestPerformanceFramework.Models;

namespace requestPerformanceTest.Services
{
    public interface IRequestService
    {
        public Task<Response> GetReponse();
    }
}
