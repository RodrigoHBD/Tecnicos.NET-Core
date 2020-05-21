using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Boundries;

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
                    throw new Exception($"Username '{user}' does not exist");
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
