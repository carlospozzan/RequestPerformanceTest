using RequestPerformanceFramework.Models;
using requestPerformanceTest.Repositories;

namespace requestPerformanceTest.Services
{
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository _requestRepository;

        public RequestService(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public Response GetReponse()
        {

            return _requestRepository.GetResponse();
        }
    }
}
