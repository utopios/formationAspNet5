using System;
using FormationAspNet5.Interfaces;

namespace FormationAspNet5.Services
{
    public class UniqueIdService : ITestService
    {
        public UniqueIdService()
        {
        }

        public string UniqueId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
