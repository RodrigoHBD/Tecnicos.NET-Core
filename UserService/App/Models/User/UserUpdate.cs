using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.App.Models
{
    public class UserUpdate
    {
        public string Username { get; set; } = "";

        private string _Password { get; set; }

        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                if(value.Length > 0)
                {
                    MustUpdate.Password = true;
                }
                _Password = value;
            }
        }

        public UpdateFlag MustUpdate { get; set; }

        public UserUpdate()
        {
            MustUpdate = new UpdateFlag();
        }
            
    }

    public class UpdateFlag
    {
        public bool Password { get; set; } = false;
    }
}
