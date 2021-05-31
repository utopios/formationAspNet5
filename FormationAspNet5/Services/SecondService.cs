using System;
using FormationAspNet5.Interfaces;

namespace FormationAspNet5.Services
{
    public class SecondService
    {
        ITestScopedService _testScopedService;
        public SecondService(ITestScopedService  testScopedService)
        {
            _testScopedService = testScopedService;
        }

        public string getId()
        {
            return _testScopedService.UniqueId();
        }
    }
}
