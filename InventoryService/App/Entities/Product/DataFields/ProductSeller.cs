using InventoryService.App.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.CustomExceptions;

namespace InventoryService.App.Entities.ProductDataFields
{
    public class ProductSeller
    {
        public static async Task Validate(string seller)
        {
            try
            {
                var isValid = await UsernameEntity.ValidateUsernameBool(seller);

                if (!isValid)
                {
                    throw new ValidationException("Vendedor", "Esse vendedor nao existe");
                }

                return;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
