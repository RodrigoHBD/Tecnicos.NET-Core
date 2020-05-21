using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Boundries;
using UserService.App.Models;

namespace UserService.App.UseCases
{
    public class GetUserData
    {
        public static async Task<User> Execute(string user)
        {
            try 
            {
                return await DAO.GetUserData(user);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
