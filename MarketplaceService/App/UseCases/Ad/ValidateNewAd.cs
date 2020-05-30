using MarketplaceService.App.Entities;
using MarketplaceService.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceService.App.UseCases
{
    public class ValidateNewAd
    {
        public static async Task Execute(Ad ad)
        {
            try
            {
                await AdEntity.ValidateNewAd(ad);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
