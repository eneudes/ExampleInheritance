namespace ExampleInheritance.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFree { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(double customsFree)
        {
            CustomsFree = customsFree;
        }

        public double TotalPrice()
        {
            return;
        }

        public override string PriceTag()
        {
            return base.PriceTag();
        }
    }
}
