using System;
using FormationAspNet5.Interfaces;

namespace FormationAspNet5.Services
{
    public class UniqueId2Service : ITestSignletonService
    {
        private string id;
        public UniqueId2Service()
        {
            id = Guid.NewGuid().ToString();
        }

        public string UniqueId()
        {
            return id;
        }
    }
}
