using MarketplaceService.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketplaceService.App.Factories;

namespace MarketplaceService.App.UseCases
{
    public class CreateNewAd
    {
        public static Ad Execute()
        {
			try
			{
				return AdFactory.MakeAd();
			}
			catch (Exception e)
			{
				throw e;
			}
        }
    }
}
