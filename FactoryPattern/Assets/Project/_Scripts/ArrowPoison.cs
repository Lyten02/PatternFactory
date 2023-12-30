using UnityEngine;

namespace Lyten.FactoryPattern
{
    public class ArrowPoison : FactoryArrow
    {
        public ArrowPoison(string name, int price, int damage) : base(name, price, damage)
        {
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Arrow: {Damage}";
        }
    }
}
