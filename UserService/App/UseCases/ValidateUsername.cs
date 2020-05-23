using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Boundries;
using UserService.App.CustomExceptions;

namespace UserService.App.UseCases
{
    public class ValidateUsername
    {
        public static async Task Execute(string user)
        {
            try
            {
                var userExist = await DAO.CheckIfUserExist(user);

                if (!userExist)
                {
                    throw new ValidationException("Username", "Esse nome de usuario nao existe");
                }
                else
                {
                    return;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
