using System.Collections.Generic;

namespace ConsignmentShopLibrary
{
    public class Store
    {
        public string Name { get; set; }
        public List<Vendor> Vendors { get; set; }
        public List<Item> Items { get; set; }
        public Store()
        {
            Vendors = new List<Vendor>();
            Items = new List<Item>();
        }
    }
}
