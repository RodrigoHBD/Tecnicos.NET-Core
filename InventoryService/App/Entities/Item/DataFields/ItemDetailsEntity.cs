using InventoryService.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.CustomExceptions;

namespace InventoryService.App.Entities.ItemDataFields
{
    public class ItemDetailsEntity
    {
        public static void Validate(ItemDetail detail)
        {
            try
            {
                var nameIsTooShort = detail.Name.Length < 2;
                var valueIsTooShort = detail.Value.Length < 2;

                if (nameIsTooShort)
                {
                    throw new ValidationException("Nome da caracteristica", "precisa ter 1 caracter no minimo.");
                }
                if (valueIsTooShort)
                {
                    throw new ValidationException("Valor da caracteristica", "precisa ter 1 caracter no minimo.");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void ValidateList(List<ItemDetail> details)
        {
            try
            {
                details.ForEach(detail => Validate(detail));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
