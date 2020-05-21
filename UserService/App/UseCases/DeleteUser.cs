using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Boundries;

namespace UserService.App.UseCases
{
    public class DeleteUser_
    {
        public static async Task Execute(string user)
        {
            try
            {
                await DAO.DeleteUser(user);
                return;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
