using RequestPerformanceFramework;
using RequestPerformanceFramework.Models;

namespace requestPerformanceTest.Repositories
{
    public class RequestRepository : IRequestRepository
    {
        public async Task<Response> GetResponse()
        {
            return ResponseGenerator.GetResponse();

        }
    }
}
