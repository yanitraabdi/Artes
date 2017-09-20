using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Model
{
    public class Category : GeneralModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaTitle { get; set; }
        public string PriceRanges { get; set; }
    }
}
