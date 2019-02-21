using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfessionalPortfolio.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PortfolioDbContext _dbContext;

        public UnitOfWork(PortfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<int> CompleteAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            this._dbContext.Dispose();
        }
    }
}
