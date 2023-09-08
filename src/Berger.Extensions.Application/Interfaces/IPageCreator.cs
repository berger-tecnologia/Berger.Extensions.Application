namespace Berger.Extensions.Application
{ 
    public interface IPageCreator<T> where T : class
    {
        T Create();
    }
}