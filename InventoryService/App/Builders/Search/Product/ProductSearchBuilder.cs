using InventoryService.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.Models.Input;

namespace InventoryService.App.Builders
{
    public class ProductSearchBuilder
    {
        public static ProductSearch Build(IProductSearchRequest request)
        {
			try
			{
				var search = new ProductSearch();
				SetStringFlags(search, request);
				SetNumberFlags(search, request);
				SetValues(search, request);
				return search;
			}
			catch (Exception e)
			{
				throw e;
			}
        }

		private static void SetStringFlags(ProductSearch search, IProductSearchRequest request)
		{
			try
			{
				var nameIsExactMatch = request.Name.ExactMatch;
				//for now this is always toggled on
				var sellerIsExactMatch = true;

				if (nameIsExactMatch)
				{
					search.Name.Flags.ExactMatch = true;
				}
				if (sellerIsExactMatch)
				{
					search.Seller.Flags.ExactMatch = true;
				}
				return;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		private static void SetNumberFlags(ProductSearch search, IProductSearchRequest request)
		{
			try
			{
				SetPriceFlags(search, request);
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		private static void SetPriceFlags(ProductSearch search, IProductSearchRequest request)
		{
			try
			{
				if (request.Price.Operator == Models.Input.NumberOperator.Greater)
				{
					search.Price.Flags.Operator = Models.NumberOperator.Greater;
				}

				if (request.Price.Operator == Models.Input.NumberOperator.Equals)
				{
					search.Price.Flags.Operator = Models.NumberOperator.Equals;
				}

				if (request.Price.Operator == Models.Input.NumberOperator.Lesser)
				{
					search.Price.Flags.Operator = Models.NumberOperator.Lesser;
				}

				return;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		private static void SetValues(ProductSearch search, IProductSearchRequest request)
		{
			try
			{
				search.Name.Value = request.Name.Value;
				search.Seller.Value = request.Seller.Value;
				search.Price.Value = request.Price.Value;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

	}
}
