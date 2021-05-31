using System;
using System.Security.Cryptography;
using System.Text;
using FormationAspNet5.Interfaces;

namespace FormationAspNet5.Services
{
    public class HashService : IHash
    {

        private string salt = "salt for password";
        private int iterationsNumber = 1000;

        public HashService()
        {
        }

        public bool CheckHash(string hash, string password)
        {
            return hash == HashPassword(password);
        }

        public string HashPassword(string password)
        {
            using Rfc2898DeriveBytes algo = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes(salt), iterationsNumber, HashAlgorithmName.SHA256);
            return Convert.ToBase64String(algo.GetBytes(32));

            //return Convert.ToBase64String(SHA256.HashData(Encoding.UTF8.GetBytes(password)));
        }
    }
}
