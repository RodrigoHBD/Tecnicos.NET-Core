using InventoryService.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.Entities.ItemDataFields;

namespace InventoryService.App.Entities
{
    public class ItemEntity : ProductEntity
    {
        public static async Task ValidateNewItem(Item item)
        {
            try
            {
                await Validate(item);
                ValidateTypeExclusiveDataFields(item);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        private static void ValidateTypeExclusiveDataFields(Item item)
        {
            try
            {
                ItemDetailsEntity.ValidateList(item.Details);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
