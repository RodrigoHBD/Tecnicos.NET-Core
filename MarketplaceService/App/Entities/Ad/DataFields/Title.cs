using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceService.App.Entities.AdDataFields
{
    public class Title
    {
        public static void Validate(string title)
        {
            try
            {
                var isTooShort = title.Length < 5;

                if (isTooShort)
                {

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
