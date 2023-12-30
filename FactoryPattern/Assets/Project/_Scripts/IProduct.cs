namespace Lyten.FactoryPattern
{
    public interface IProduct 
    {
        IProduct Create();
        void Print();
    }
}
