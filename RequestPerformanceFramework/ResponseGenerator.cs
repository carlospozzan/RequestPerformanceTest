using RequestPerformanceFramework.Models;

namespace RequestPerformanceFramework
{
    public static class ResponseGenerator
    {
        public static Response GetResponse()
        {
            Task.Delay(TimeSpan.FromMilliseconds(200)).Wait();
            return new Response()
            {
                Id = Guid.NewGuid()
            };
        }
    }
}
