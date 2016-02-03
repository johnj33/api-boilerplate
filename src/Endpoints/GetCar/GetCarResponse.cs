using System.Collections.Generic;
using api.boilerplate.Domain;

namespace api.boilerplate.Endpoints.GetCar
{
    public class GetCarResponse
    {
        public IEnumerable<Car> Cars { get; set; }
    }
}
