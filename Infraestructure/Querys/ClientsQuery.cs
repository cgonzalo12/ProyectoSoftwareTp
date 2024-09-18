using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Querys
{
    public class ClientsQuery : IClientsQuery
    {
        public readonly AppDbContext _context;

        public ClientsQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Clients> GetClient(string id)
        {

            if (Guid.TryParse(id, out var clientId))
            {
                var client = await _context.Clients.FirstOrDefaultAsync(c => c.ClientID == clientId);
                return client;
            }
            return null;
        }

        public async Task<List<Clients>> GetAllClients()
        {
            var listClients = await _context.Clients.ToListAsync();
            return listClients;
        }
    }
}
