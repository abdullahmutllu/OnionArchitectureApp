namespace OnionApp.Domain
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}
