using UnityEngine;
using System.Linq;

namespace Lyten.FactoryPattern
{
    public class Example : MonoBehaviour
    {
        private void Start()
        {
            IProduct[] product = new IProduct[]
            {
                new Product("Name", 10),
                new ArrowPoison("Arrow", 100, 1),
            };
            
            product.ToList().ForEach(x => ((FactoryBase)x).Print());
        }
    }
}
