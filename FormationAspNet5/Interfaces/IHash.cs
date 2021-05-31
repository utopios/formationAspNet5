using System;
namespace FormationAspNet5.Interfaces
{
    public interface IHash
    {
        string HashPassword(string password);
        bool CheckHash(string hash, string password);
    }
}
