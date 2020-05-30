using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceService.App.UseCases
{
    public class AdUseCaseOperator
    {
        public static async Task PublishNewAd()
        {
            try
            {
                var ad = CreateNewAd.Execute();
                await ValidateNewAd.Execute(ad);
                await RegisterAd.Execute(ad);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
