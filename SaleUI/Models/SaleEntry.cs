using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleUI.Models
{
    public class SaleEntry
    {
        public string Id { get; set; }
        public string ProductSKU { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public string Branch { get; set; }
        public string SoldBy { get; set; }
        public DateTime SaleDate { get; set; }
        public DateTime TimeStamp { get; set; }
        public string EncodedBy { get; set; }
    }
}
