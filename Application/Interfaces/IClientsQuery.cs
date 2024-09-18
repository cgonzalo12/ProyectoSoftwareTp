using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IClientsQuery
    {
        Task<List<Clients>> GetAllClients();

        Task<Clients> GetClient(string id);

        
    }
}
