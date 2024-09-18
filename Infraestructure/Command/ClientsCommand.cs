using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Command
{
    public class ClientsCommand : IClientsCommand
    {
        private readonly AppDbContext _context;

        public ClientsCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task InsertClient(Clients client)
        {
            _context.Add(client);

            await _context.SaveChangesAsync();
        }

        public Task RemoveClient(int clientId)
        {
            throw new NotImplementedException();
        }

        public async Task GetAllClients()
        {
             await _context.Clients.ToListAsync();
        }
    }
}
