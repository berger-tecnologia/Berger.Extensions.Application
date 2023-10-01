namespace Berger.Extensions.Application
{ 
    public interface ICreation<T> where T : class
    {
        T Create();
    }
}