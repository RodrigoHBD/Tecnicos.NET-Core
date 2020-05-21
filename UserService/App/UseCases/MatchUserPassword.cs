using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Models;

namespace UserService.App.UseCases
{
    public class MatchUserPassword
    {
        public static bool Execute(User user, string input)
        {
			try
			{
				if(user.Password == input)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception e)
			{
				throw e;
			}
		}
    }
}
