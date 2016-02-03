using System;

namespace api.boilerplate.Domain
{
    public class Car
    {
        public Guid CarId { get; set; }

        public CarType CarType { get; set; }

        public string Registration { get; set; }

        public int YearBought { get; set; }
    }
}
