using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Models
{
    public class ProductSearch
    {
        public StringSearchField Seller { get; set; }
        public StringSearchField Name { get; set; }
        public DecimalNumberSearchField Price { get; set; }
        public Pagination Pagination { get; set; }
        public ProductSearch()
        {
            Seller = new StringSearchField();
            Name = new StringSearchField();
            Price = new DecimalNumberSearchField();
            Pagination = new Pagination();
        }
    }

    public class StringSearchField
    {
        public string Value { get; set; } 
        public StringSearchFlags Flags { get; set; }
        public StringSearchField()
        {
            Flags = new StringSearchFlags();
        }
    }

    public class IntNumberSearchField
    {
        public int Value { get; set; }
        public NumberSearchFlags Flags { get; set; }
        public IntNumberSearchField()
        {
            Flags = new NumberSearchFlags();
        }
    }

    public class DecimalNumberSearchField
    {
        public decimal Value { get; set; }
        public NumberSearchFlags Flags { get; set; }
        public DecimalNumberSearchField()
        {
            Flags = new NumberSearchFlags();
        }
    }

    public class StringSearchFlags
    {
        public bool ExactMatch { get; set; } = false;
    }

    public class NumberSearchFlags
    {
        public NumberOperator Operator { get; set; } = NumberOperator.Equals;
    }

    public enum NumberOperator
    {
        Lesser,
        Equals,
        Greater
    }
}
