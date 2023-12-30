namespace Lyten.FactoryPattern
{
    public abstract class FactoryArrow : FactoryBase
    {
        public int Damage { get; set; }

        public FactoryArrow(string name, int price, int damage) : base(name, price)
        {
            Damage = damage;
        }
    }
}
