using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Entities.ProductDataFields
{
    public class ProductPrice
    {
        public static void Validate(float price)
        {
            try
            {
                var isLesserThanZero = price < 0;

                if (isLesserThanZero)
                {
                    throw new Exception("Preco nao pode ser menor que 0.00");
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
