using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthService.App.Models
{
    public class Credential
    {
        public string User { get; set; }

        public AccessLevels.AvailableAccessLevels AccessLevel { get; set; }

        public Privileges Privileges { get; set; }

        public Credential()
        {
            AccessLevel = AccessLevels.AvailableAccessLevels.Public;
        }
    }


}
