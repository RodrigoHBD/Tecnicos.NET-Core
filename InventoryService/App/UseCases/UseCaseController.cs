using InventoryService.App.Factories;
using InventoryService.App.Builders;
using InventoryService.App.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.Models;
using InventoryService.App.Models.Output;
using InventoryService.App.Entities.ProductTypes;
using InventoryService.App.Entities;

namespace InventoryService.App.UseCases
{
    public class UseCaseController
    {
        public static async Task AddServiceToUserInventory(INewServiceRequest request)
        {
			try
			{
				var service = CreateNewService.Execute(request);
				await ValidateNewService.Execute(service);
				await RegisterService.Execute(service);
			}
			catch (Exception e)
			{
				throw e;
			}
        }

		public static async Task AddItemToInvetory()
		{
			try
			{

			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public static async Task<IServiceList> GetUserServicesWithPagination(IGetProductRequest request)
		{
			try
			{
				await UsernameEntity.ValidateUsername(request.Seller);
				return await GetUserServices.Execute(request);
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		// Get by Id section
		public static async Task<Service> GetServiceDataById(string id)
		{
			try
			{
				await ServiceEntity.ValdiateId(id);
				return await GetServiceData.Execute(id);
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		// Search with filters section

		public static async Task<IServiceList> SearchServicesWithFilters(IServiceSearchRequest request)
		{
			try
			{
				ProductSearchObjEntity.Validate(request);
				var result = await SearchService.Execute(request);
				return result;
			}
			catch (Exception e)
			{
				throw e;
			}
		}
    }
}
