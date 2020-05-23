using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.CustomExceptions
{
    public class CustomException : Exception
    {
        public string Type { get; protected set; }
        public CustomException()
        {

        }

        public CustomException(string message) : base(message)
        {

        }

        public CustomException(string message, Exception inner) : base(message, inner)
        {

        }
    }

}
