using System;
namespace FormationApiRest.Interfaces
{
    public interface ITokenGenerator
    {
        string GenerateToken(string userName, string password);
    }
}
