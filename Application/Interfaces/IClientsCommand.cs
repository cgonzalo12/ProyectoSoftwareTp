﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IClientsCommand
    {
        Task InsertClient(Clients client);
        Task RemoveClient(int clientId);

        Task GetAllClients();


    }
}
