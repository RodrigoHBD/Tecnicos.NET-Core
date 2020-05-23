using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Boundries;
using UserService.App.CustomExceptions;

namespace UserService.App.UseCases
{
    public class ValidateUsernameBool
    {
        public static async Task<bool> Execute(string user)
        {
            try
            {
                return await DAO.CheckIfUserExist(user);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
