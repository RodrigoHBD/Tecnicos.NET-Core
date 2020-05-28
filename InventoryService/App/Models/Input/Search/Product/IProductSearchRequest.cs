using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Models.Input
{
    public interface IProductSearchRequest
    {
        IStringSearchField Name { get; }
        IStringSearchField Seller { get; }
        IDecimalSearchField Price { get; }
        IPagination Pagination { get; }
    }

    public interface IStringSearchField
    {
        string Value { get; }
        bool ExactMatch { get; }
        IFieldFlags Flags { get; }
    }

    public interface IDecimalSearchField
    {
        decimal Value { get; }
        NumberOperator Operator { get; }
        IFieldFlags Flags { get; }
    }

    public interface IFieldFlags
    {
        bool IsActive { get; set; }
    }

    public enum NumberOperator
    {
        Lesser,
        Equals,
        Greater,
    }
}
