using RequestPerformanceFramework.Models;

namespace requestPerformanceTest.Repositories
{
    public class RequestRepository : IRequestRepository
    {
        public async Task<Response> GetResponse()
        {
            Task.Delay(TimeSpan.FromSeconds(10)).Wait();
            return new Response()
            {
                Id = Guid.NewGuid()
            };
        }
    }
}
