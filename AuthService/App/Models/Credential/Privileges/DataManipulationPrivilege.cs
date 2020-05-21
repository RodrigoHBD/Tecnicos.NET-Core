using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthService.App.Models.CredentialPrivileges
{
    public class DataManipulationPrivilege
    {
        public bool Read { get; set; } = false;

        public bool Write { get; set; } = false;

        public bool Override { get; set; } = false;

        public bool Delete { get; set; } = false;
    }
}
