using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UserService.App.Boundries;
using UserService.App.CustomExceptions;

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
                    throw new ValidationException("username", "Deve conter 5 caracteres no minimo");
                }
                if (hasSpecialCharacters)
                {
                    throw new ValidationException("username", "Nao pode conter caracteres especiais");
                }
                if (usernameIsTaken)
                {
                    throw new ValidationException("username", "Esse nome de usuario ja esta em uso, escolha outro.");
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
                    throw new ValidationException("username", "Deve conter 5 caracteres no minimo");
                }
                if (hasSpecialCharacters)
                {
                    throw new ValidationException("username", "Nao pode conter caracteres especiais");
                }
                if (!usernameExist)
                {
                    throw new ValidationException("username", "Esse nome de usuario nao existe");
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
