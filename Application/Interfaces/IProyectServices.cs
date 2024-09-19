using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProyectServices
    {
        Task<List<Proyects>> GetAllProyects();

        Task<Proyects> CrearProyect(CreateProyectDTO proyectDTO);

        Task<Proyects> GetById(string proyectID);
    }
}
