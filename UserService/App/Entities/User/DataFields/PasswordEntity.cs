using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.App.Entities.UserDataFields
{
    public class PasswordEntity
    {
        public static void Validate(string password)
        {
			try
			{
				var isTooShort = password.Length < 8;

				if(isTooShort)
				{
					throw new Exception($"senha deve ter no pelo menos 8 caracteres");
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
