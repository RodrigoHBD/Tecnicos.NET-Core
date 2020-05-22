using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InventoryService.App.Entities.Product.DataFields
{
    public class ProductName
    {
		private static Regex Regex { get; } = new Regex(@"/[^0-9A-z]/g");
        public static void Execute(string name)
        {
			try
			{
				var hasSpecialCharacters = Regex.IsMatch(name);
				var isTooShort = name.Length < 5;

				if (hasSpecialCharacters)
				{
					throw new Exception("");
				}
				if (isTooShort)
				{
					throw new Exception("");
				}
			}
			catch (Exception e)
			{
				throw e;
			}
        }
    }
}
