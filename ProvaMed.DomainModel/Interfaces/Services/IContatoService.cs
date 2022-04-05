using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProvaMed.DomainModel.Entity;

namespace ProvaMed.DomainModel.Interfaces.Services
{
    public interface IContatoService
    {  
        Task Add(Contato Contato);
        Task Update(Contato Contato);
        Task Delete(Guid id);
        Task<Contato> Get(Guid id);
        Task<IEnumerable<Contato>> GetAll();
    }
}
