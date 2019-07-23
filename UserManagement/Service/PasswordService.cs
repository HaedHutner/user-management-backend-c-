using System;
using System.Security.Cryptography;

namespace UserManagement.Service
{
    public class PasswordService
    {
        private const int SaltLength = 16;

        private const int HashLength = 20;

        private const int NumberOfIterations = 2000;

        private readonly RNGCryptoServiceProvider _rngCryptoServiceProvider = new RNGCryptoServiceProvider();

        public PasswordService()
        {
        }

        public string HashPassword(string rawPassword)
        {
            byte[] salt;
            _rngCryptoServiceProvider.GetBytes(salt = new byte[SaltLength]);

            var pbkdf2 = new Rfc2898DeriveBytes(rawPassword, salt, NumberOfIterations);
            byte[] hash = pbkdf2.GetBytes(HashLength);

            byte[] hashBytes = new byte[SaltLength + HashLength];
            Array.Copy(salt, 0, hashBytes, 0, SaltLength);
            Array.Copy(hash, 0, hashBytes, SaltLength, HashLength);

            return Convert.ToBase64String(hashBytes);
        }

        public bool MatchPassword(string rawPassword, string hashedPassword)
        {
            // Convert hashedPassword to bytes
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);

            // Get salt bytes
            byte[] salt = new byte[SaltLength];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Compute the hash on the password the user entered
            var pbkdf2 = new Rfc2898DeriveBytes(rawPassword, salt, NumberOfIterations);
            byte[] hash = pbkdf2.GetBytes(HashLength);

            // Compare the results
            for (int i = 0; i < HashLength; i++)
            {
                if (hashBytes[i + SaltLength] != hash[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}