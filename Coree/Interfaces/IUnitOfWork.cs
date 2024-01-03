namespace Coree.Interfaces
{
    public interface IUnitOfWork<T> where T : class
    {
        //need to define what is the relevent Entity or Repository 
        IGenericRepository<T> Entity { get; }
        //to save all object transactions
        void Save();
    }
}
