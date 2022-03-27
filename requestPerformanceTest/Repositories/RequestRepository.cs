using RequestPerformanceFramework;
using RequestPerformanceFramework.Models;

namespace requestPerformanceTest.Repositories
{
    public class RequestRepository : IRequestRepository
    {
        public Response GetResponse()
        {
            return ResponseGenerator.GetResponse();
        }
    }
}
