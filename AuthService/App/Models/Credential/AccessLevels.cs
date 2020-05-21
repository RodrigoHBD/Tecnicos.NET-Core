using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthService.App.Models
{
    public class AccessLevels
    {
        public enum AvailableAccessLevels
        {
            Admin = 0,
            SystemMaintainer = 1,
            SuperUser = 2,
            Staff = 3,
            User = 4,
            Public = 5
        }
    }
}
