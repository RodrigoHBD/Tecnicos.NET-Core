using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Initializer
{
    public class DatabaseInitializer
    {
        public static async Task Initialize()
        {
			try
			{
				await DB.Connect();
				await Collections.Initialize();
			}
			catch (Exception e)
			{
				throw e;
			}
        }
    }
}
