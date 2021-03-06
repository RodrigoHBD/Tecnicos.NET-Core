﻿using InventoryService.App.Boundries;
using InventoryService.App.CustomExceptions;
using InventoryService.App.Entities.ProductTypes.ServiceDataFields;
using InventoryService.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Entities.ProductTypes
{
    public class ServiceEntity : ProductEntity
    {
        public static async Task ValidateNewService(Service service)
        {
            try
            {
                await Validate(service);
                await ValidateTypeExclusiveDataFields(service);
                return;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private static async Task ValidateTypeExclusiveDataFields(Service service)
        {
            try
            {
                ServiceWarranty.Validate(service.WarrantyInDays);
                return;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task ValdiateId(string id = "")
        {
            try
            {
                var servceExist = await ServiceDAO.CheckIfServiceExist(id);

                if (!servceExist)
                {
                    throw new ValidationException("Id do servico", $"Nenhum servico registrado com a Id '{id}' ");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
