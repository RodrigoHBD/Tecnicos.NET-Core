using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.CustomExceptions;
using InventoryService.App.Models;
using InventoryService.App.Models.Input;

namespace InventoryService.App.Entities
{
    public class ProductSearchObjEntity
    {
        public static void Validate(IProductSearchRequest search)
        {
            try
            {
                ValidatePagination(search.Pagination);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        private static void ValidatePagination(IPagination pagination)
        {
            try
            {
                var limitMax = 25;
                var noneAreLessThanZero = !(pagination.Limit < 0) && !(pagination.Offset < 0);
                var limitDoesNotExeedItsMaxValue = !(pagination.Limit > limitMax);

                if (!noneAreLessThanZero)
                {
                    throw new ValidationException("Paginacao", "Offset e Limit nao podem ser menor que zero");
                }
                if (!limitDoesNotExeedItsMaxValue)
                {
                    throw new ValidationException("Paginacao", $"Limit nao pode exeder '{limitMax}' ");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
