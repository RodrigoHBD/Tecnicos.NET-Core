using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Initializer
{
    public class AppInitializer
    {
        public static async Task Initialize()
        {
            try
            {
                await InitializeDatabase();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private static async Task InitializeDatabase()
        {
            try
            {
                await DatabaseInitializer.Initialize();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
