using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InventoryService.App.Entities.ProductDataFields
{
    public class ProductName
    {
		private static Regex Regex { get; } = new Regex(@"/[^0-9A-z]/g");
        public static void Validate(string name)
        {
			try
			{
				var hasSpecialCharacters = Regex.IsMatch(name);
				var isTooShort = name.Length < 5;

				if (hasSpecialCharacters)
				{
					throw new Exception("Nome não pode conter caracteres especiais");
				}
				if (isTooShort)
				{
					throw new Exception("Nome muito curto, minimo 5 caracteres");
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
