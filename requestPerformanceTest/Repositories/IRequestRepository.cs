using RequestPerformanceFramework.Models;

namespace requestPerformanceTest.Repositories
{
    public interface IRequestRepository
    {
        Response GetResponse();
    }
}