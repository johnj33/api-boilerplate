using System;
using api.boilerplate.Domain;

namespace Service.Tests.Acceptance.Models
{
    public class Car
    {
        public Guid CarId { get; set; }

        public CarType CarType { get; set; }

        public string Registration { get; set; }

        public int YearBought { get; set; }
    }
}