using System;
using System.Collections.Generic;
using System.Linq;
using api.boilerplate.Database;
using Service.Tests.Acceptance.Models;
using TechTalk.SpecFlow;

namespace Service.Tests.Acceptance.Steps
{
    [Binding]
    public class ValidateCarSteps
    {
        [Given(@"the following car data")]
        public void GivenTheFollowingCarData(IEnumerable<Car> convoy)
        {
            foreach (var car in convoy)
            {
                Data.CarData.Add(new api.boilerplate.Domain.Car
                {
                    CarType = car.CarType,
                    CarId = Guid.NewGuid(),
                    Registration = car.Registration,
                    YearBought = car.YearBought
                });
            }

        }
        
        [When(@"the endpoint is called")]
        public void WhenTheEndpointIsCalled()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the following data should be returned")]
        public void ThenTheFollowingDataShouldBeReturned()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the api will return a response of OK")]
        public void ThenTheApiWillReturnAResponseOfOK()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
