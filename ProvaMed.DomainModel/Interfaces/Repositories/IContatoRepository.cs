using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProvaMed.DomainModel.Entity;

namespace ProvaMed.DomainModel.Interfaces.Repositories
{
    public interface IContatoRepository : IRepository<Contato>
    {
        Task<IEnumerable<Contato>> GetContatos();

        Task<Contato> GetContato(Guid id);
    }
}
