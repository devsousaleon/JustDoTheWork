using System.Data;

namespace JustDoTheWork.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        IDbConnection Connection { get; }
        IDbTransaction Transaction { get; }
        void Begin();
        void Commit();
        void Rollback();
    }

    public interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }
}
