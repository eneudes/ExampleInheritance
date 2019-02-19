using System;
using System.Text;

namespace ExampleInheritance.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} (used) ${Price} (manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})");
            return sb.ToString();
        }
    }
}
