using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase
{
    public class ClientsServices : IClientServices
    {
        private readonly IClientsCommand _command;
        private readonly IClientsQuery _query;
        private readonly IGenerateID _idGenerator;

        public ClientsServices(IClientsCommand command, IClientsQuery query, IGenerateID idGenerator)
        {
            _command = command;
            _query = query;
            _idGenerator = idGenerator;
        }

        public async Task<Clients> CrearClient(CreateClientDTO clientDTO)
        {
            var clientId = _idGenerator.GenerateID();

            var client = new Clients
            {
                ClientID = clientId,
                Name = clientDTO.Name,
                Email = clientDTO.Email,
                Proyects = new List<Proyects>()
            };
            await _command.InsertClient(client);
            return client;
        }

        public Task<Clients> DeleteClientt(int clientId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Clients>> GetAllClients()
        {
            return await _query.GetAllClients();
        }

        public async Task<Clients> GetById(string clientId)
        {
            return await _query.GetClient(clientId);

        }

    }
}
