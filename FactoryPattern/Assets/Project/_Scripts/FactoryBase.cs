using System;
using UnityEngine;

namespace Lyten.FactoryPattern
{
    public abstract class FactoryBase : IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public FactoryBase(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public abstract override string ToString();

        public void Print()
        {
            Debug.Log(ToString());
        }

        public override bool Equals(object obj)
        {
            return obj is FactoryBase factory &&
                   Name == factory.Name &&
                   Price == factory.Price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price);
        }

        public IProduct Create()
        {
            return this;
        }
    }
}
