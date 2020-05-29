using InventoryService.App.Factories;
using InventoryService.App.Models;
using InventoryService.App.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.UseCases
{
    public class CreateNewItem
    {
        public static Item Execute (INewItemRequest request)
        {
            try
            {
                return ItemFactory.MakeItem(request);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
