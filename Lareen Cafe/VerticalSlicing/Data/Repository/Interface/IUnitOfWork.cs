using LareenCafe.Api.VerticalSlicing.Data.Entities;

namespace LareenCafe.Api.VerticalSlicing.Data.Repository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T> Repository<T>() where T : BaseEntity;
        Task<int> SaveChangesAsync();

    }
}
