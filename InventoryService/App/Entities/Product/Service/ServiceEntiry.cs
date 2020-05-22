using InventoryService.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Entities.ProductTypes
{
    public class ServiceEntiry : ProductEntity
    {
        private static int MinimumWarrantyInDays { get; set; } = 15;

        public static async Task ValidateService(Service service)
        {
            try
            {
                await Validate(service);
                await ValidateTypeExclusiveDataFields(service);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private static async Task ValidateTypeExclusiveDataFields(Service service)
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
