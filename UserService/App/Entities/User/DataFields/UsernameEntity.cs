using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UserService.App.Boundries;

namespace UserService.App.Entities.UserDataFields
{
    public class UsernameEntity
    {
        private static Regex TestRegex { get; } = new Regex(@"[^A-z-_\d]+");
        public static async Task ValidateNew(string user)
        {
            try
            {
                var isTooShort = user.Length < 5;
                var hasSpecialCharacters = TestRegex.IsMatch(user);
                var usernameIsTaken = await DAO.CheckIfUserExist(user);

                if (isTooShort)
                {
                    throw new Exception($"username deve ter no pelo menos 5 caracteres");
                }
                if (hasSpecialCharacters)
                {
                    throw new Exception($"username não deve conter caracteres especiais");
                }
                if (usernameIsTaken)
                {
                    throw new Exception($"username '{user}' já está em uso, escolha outro");
                }
                return;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task ValidateExistent(string user)
        {
            try
            {
                var isTooShort = user.Length < 5;
                var hasSpecialCharacters = TestRegex.IsMatch(user);
                var usernameExist = await DAO.CheckIfUserExist(user);

                if (isTooShort)
                {
                    throw new Exception($"username deve ter no pelo menos 5 caracteres");
                }
                if (hasSpecialCharacters)
                {
                    throw new Exception($"username não deve conter caracteres especiais");
                }
                if (!usernameExist)
                {
                    throw new Exception($"Nome de usuario inexistente");
                }
                return;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
