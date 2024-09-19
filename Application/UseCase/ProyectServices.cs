using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase
{
    public class ProyectServices :IProyectServices
    {
        private readonly IProyectQuery _query;

        public ProyectServices(IProyectQuery query)
        {
            _query = query;
        }

        public async Task<List<Proyects>> GetAllProyects()
        {
           return await _query.GetAlProyects();
        }
    }
}
