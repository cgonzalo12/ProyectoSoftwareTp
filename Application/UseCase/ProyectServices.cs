using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase
{
    public class ProyectServices :IProyectServices
    {
        private readonly IProyectQuery _query;
        private readonly IProyectCommand _command;
        private readonly IGenerateID _generateID;

        public ProyectServices(IProyectQuery query, IProyectCommand command, IGenerateID generateID)
        {
            _query = query;
            _command = command;
            _generateID = generateID;
        }

        public async Task<Proyects> CrearProyect(CreateProyectDTO proyectDTO)
        {
            var proyecId = _generateID.GenerateID();

            var proyect = new Proyects
            {
                ProjectID = proyecId,
                Name = proyectDTO.Name,
                ClientID = proyectDTO.ClientID,
                CampaignType = proyectDTO.CampaignType,
                StartDate = proyectDTO.StartDate,
                EndDate = proyectDTO.EndDate,
                Tasks = new List<Tasks>(),
                Interactions = new List<Interactions>()
            };
            await _command.InsertProyect(proyect);
            return proyect;
        }

        public async Task<List<Proyects>> GetAllProyects()
        {
           return await _query.GetAlProyects();
        }

        public async Task<Proyects> GetById(string proyectID)
        {
            return await _query.GetProyect(proyectID);
        }
    }
}
