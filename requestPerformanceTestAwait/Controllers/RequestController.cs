using Microsoft.AspNetCore.Mvc;
using RequestPerformanceFramework.Models;
using requestPerformanceTest.Services;

namespace requestPerformanceTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RequestController : ControllerBase
    {
        private readonly IRequestService _requestService;

        private readonly ILogger<RequestController> _logger;

        public RequestController(ILogger<RequestController> logger, IRequestService requestService)
        {
            _logger = logger;
            _requestService = requestService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<ActionResult<Response>> Get()
        {
            return Ok(await _requestService.GetReponse());
        }
    }
}