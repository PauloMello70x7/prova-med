using System.Threading.Tasks;
using ProvaMed.DomainModel.Interfaces.UoW;
using ProvaMed.Infra.Context;

namespace ProvaMed.Infra.UoW
{
    public class EntityFrameworkUnitOfWork : IUnitOfWork
    {
        private readonly ProvaMedContext _context;

        public EntityFrameworkUnitOfWork(ProvaMedContext context)
        {
            this._context = context;
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

      
    }
}
