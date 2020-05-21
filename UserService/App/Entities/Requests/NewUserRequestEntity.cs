using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Models.UseCases.Input;

namespace UserService.App.Entities
{
    public class NewUserRequestEntity
    {
        public static void Validate(INewUserRequest request)
        {
            return;
        }
    }
}
