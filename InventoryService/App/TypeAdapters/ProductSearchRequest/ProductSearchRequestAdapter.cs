using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.Models.Input;
using InventoryService.gRPC.Server.Protos;

namespace InventoryService.App.TypeAdapters
{
    public class ProductSearchRequestAdapter
    {
        public static IProductSearchRequest Adapt(GrpcProductSearchRequest request)
        {
            try
            {
                var name = new StringSearchField()
                {
                    Value = request.Name.Value,
                    ExactMatch = request.Name.Falgs.ExactMatch
                };
                var seller = new StringSearchField()
                {
                    Value = request.Seller.Value,
                    ExactMatch = request.Seller.Falgs.ExactMatch
                };
                var price = new DecimalSearchField()
                {
                    Value = (decimal)request.Price,
                    Operator = NumberOperator.Equals
                };
                var pagination = new SearchPagination()
                {
                    Limit = request.Pagination.Limit,
                    Offset = request.Pagination.Offset
                };

                return new ProductSearchRequest()
                {
                    Name = name,
                    Seller = seller,
                    Price = price,
                    Pagination = pagination
                };
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }

    public class ProductSearchRequest : IProductSearchRequest
    {
        public IStringSearchField Name { get; set; }

        public IStringSearchField Seller { get; set; }

        public IDecimalSearchField Price { get; set; }

        public IPagination Pagination { get; set; }

        public ProductSearchRequest()
        {
            Name = new StringSearchField();
            Seller = new StringSearchField();
            Price = new DecimalSearchField();
            Pagination = new SearchPagination();
        }
    }

    public class StringSearchField : IStringSearchField
    {
        public string Value
        {
            get { return _Value; }
            set
            {
                if(value.Length > 0)
                {
                    Flags.IsActive = true;
                }
                _Value = value;
            }
        }
        private string _Value { get; set; }
        public bool ExactMatch { get; set; } = false;
        public IFieldFlags Flags { get; set; }
        public StringSearchField()
        {
            Flags = new FieldFlags();
        }
    }

    public class DecimalSearchField : IDecimalSearchField
    {
        public decimal Value { get; set; } = 0;
        public NumberOperator Operator { get; set; }
        public IFieldFlags Flags { get; }
        public DecimalSearchField()
        {
            Flags = new FieldFlags();
        }
    }

    public class FieldFlags : IFieldFlags
    {
        public bool IsActive { get; set; } = false;
    }

    public class SearchPagination : IPagination
    {
        public int Offset { get; set; } = 0;

        public int Limit { get; set; } = 0;

        public int Total { get; set; }
    }
}
