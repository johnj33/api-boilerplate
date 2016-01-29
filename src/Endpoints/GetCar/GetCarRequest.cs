
using api.boilerplate.Domain;
using ServiceStack;

namespace api.boilerplate.Endpoints.GetCar
{
    [Route("/Car/CarType/{CarType}")]
    public class GetCarRequest
    {
        public CarType CarType { get; set; }
    }
}
