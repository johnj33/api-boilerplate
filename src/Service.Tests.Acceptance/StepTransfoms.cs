using System.Collections.Generic;
using Service.Tests.Acceptance.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Service.Tests.Acceptance
{
    public class StepTransfoms
    {
        [StepArgumentTransformation]
        public IEnumerable<Car> BuildMyCar(Table carTable)
        {
            return carTable.CreateSet<Car>();
        } 
    }
}