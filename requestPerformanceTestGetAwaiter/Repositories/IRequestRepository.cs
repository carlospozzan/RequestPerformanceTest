using RequestPerformanceFramework.Models;

namespace requestPerformanceTest.Repositories
{
    public interface IRequestRepository
    {
        Task<Response> GetResponse();
    }
}