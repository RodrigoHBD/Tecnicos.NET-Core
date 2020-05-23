using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Entities.ProductTypes.ServiceDataFields
{
    public class ServiceWarranty
    {
        private static int MinimumWarrantyInDays { get; set; } = 15;

        public static void Validate(int warranty)
        {
            try
            {
                var isLesserThanMinimum = MinimumWarrantyInDays > warranty;

                if (isLesserThanMinimum)
                {
                    throw new Exception("Garantia minima e de 15 dias.");
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
