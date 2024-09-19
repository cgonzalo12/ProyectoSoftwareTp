using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IClientServices
    {
        Task<Clients> CrearClient(CreateClientDTO clientDTO);

        Task<List<Clients>> GetAllClients();
        Task<Clients> GetById(string clientId);
    }


}
