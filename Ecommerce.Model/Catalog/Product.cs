using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Model
{
    public class Product : GeneralModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaTitle { get; set; }
        public string Code { get; set; }
        public string ManufacturerPartNumber { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
        public decimal ProductCost { get; set; }
    }
}
