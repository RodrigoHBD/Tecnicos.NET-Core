using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.App.CustomErrors
{
    public class CustomError 
    {
        public CustomError() : base() { }
        //public CustomError(string message) : base(message) { }
        //public CustomError(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client.
        //protected CustomError(System.Runtime.Serialization.SerializationInfo info,
            //System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

}
