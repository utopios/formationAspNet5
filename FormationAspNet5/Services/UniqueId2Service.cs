using System;
using FormationAspNet5.Interfaces;

namespace FormationAspNet5.Services
{
    public class UniqueId2Service : ITestService
    {
        public UniqueId2Service()
        {
        }

        public string UniqueId()
        {
            return "toto-" + Guid.NewGuid().ToString();
        }
    }
}
