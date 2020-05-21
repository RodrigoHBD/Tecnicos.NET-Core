using AuthService.App.Models.CredentialPrivileges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthService.App.Models
{
    public class Privileges
    {
        public DataManipulationPrivilege OwnData { get; set; }

        public DataManipulationPrivilege OthersData { get; set; }
    }
}
