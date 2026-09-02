using System.Data;

namespace JustDoTheWork.Infrastructure
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        public IDbConnection Connection { get; }
        public IDbTransaction Transaction { get; private set; } = null!;

        public UnitOfWork(DBConnection dbConnection)
        {
            Connection = dbConnection.Create();
        }

        public void Begin()
        {
            Transaction = Connection.BeginTransaction();
        }

        public void Commit()
        {
            Transaction.Commit();
        }

        public void Rollback()
        {
            try
            {
                Transaction?.Rollback();
            }
            catch
            {
                // transação já finalizada
            }
        }

        public void Dispose()
        {
            Transaction?.Dispose();
            Connection.Dispose();
        }
    }

    public sealed class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private readonly DBConnection _dbConnection;

        public UnitOfWorkFactory(DBConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IUnitOfWork Create() => new UnitOfWork(_dbConnection);
    }
}
