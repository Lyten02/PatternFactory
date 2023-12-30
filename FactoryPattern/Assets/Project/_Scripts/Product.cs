namespace Lyten.FactoryPattern
{
    public class Product : FactoryBase
    {
        public Product(string name, int price) : base(name, price)
        {

        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}";
        }
    }
}
