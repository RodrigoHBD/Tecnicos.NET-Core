using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketplaceService.App.Models;
using MarketplaceService.App.Entities.AdDataFields;

namespace MarketplaceService.App.Entities
{
    public class AdEntity
    {
        public static async Task ValidateNewAd(Ad ad)
        {
			try
			{
				await ValidateDataFields(ad);
				await ValidateProductOwnership(ad);
			}
			catch (Exception e)
			{
				throw e;
			}
        }

		private static async Task ValidateDataFields(Ad ad)
		{
			try
			{
				Title.Validate(ad.Title);
				Description.Validate(ad.Description);
				Price.Validate(ad.Price);
				await Owner.Validate(ad.Owner);
				await ProductId.Validate(ad.ProductId);
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		private static async Task ValidateProductOwnership(Ad ad)
		{
			try
			{

			}
			catch (Exception e)
			{
				throw e;
			}
		}
    }
}
