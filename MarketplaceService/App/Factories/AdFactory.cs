using MarketplaceService.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceService.App.Factories
{
    public class AdFactory
    {
        public static Ad MakeAd()
        {
            try
            {
                return new Ad()
                {

                };
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
