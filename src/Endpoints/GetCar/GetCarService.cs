using System.Linq;
using api.boilerplate.DataAccess;
using ServiceStack;

namespace api.boilerplate.Endpoints.GetCar
{
    public class GetCarService : Service
    {
        public GetCarResponse Get(GetCarRequest request)
        {
            var carQuery = new CarQuery();

            var cars = carQuery.GetByType(request.CarType).ToList();

            if (!cars.Any())
            {
                throw HttpError.NotFound("No cars found of given type");
            }

            return new GetCarResponse {Cars = cars};
        }
    }
}
