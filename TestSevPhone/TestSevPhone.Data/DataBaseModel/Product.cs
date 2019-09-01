using System;
using System.Collections.Generic;
using System.Text;

namespace TestSevPhone.Data.DataBaseModel
{
    public class Product
    {
        public int Id { get; set; }        
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int ProductTypeId { get; set; }
    }
}