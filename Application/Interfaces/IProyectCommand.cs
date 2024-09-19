using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProyectCommand
    {
        Task GetAllProyects();
        Task InsertProyect(Proyects proyect);
    }
}
