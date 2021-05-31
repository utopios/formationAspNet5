using System;
using FormationAspNet5.Interfaces;

namespace FormationAspNet5.Services
{
    public class UniqueIdService : ITestTransientService
    {
        private string id;
        public UniqueIdService()
        {
            id = Guid.NewGuid().ToString();
        }

        public string UniqueId()
        {
            return id;
        }
    }
}
