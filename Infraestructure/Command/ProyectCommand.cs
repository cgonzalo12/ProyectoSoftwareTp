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
    public class ProyectCommand :IProyectCommand
    {
        private readonly AppDbContext _context;

        public ProyectCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task GetAllProyects()
        {
            await _context.Proyects.ToListAsync();
        }

        public async Task InsertProyect(Proyects proyect)
        {
            _context.Add(proyect);

            await _context.SaveChangesAsync();
        }
    }
}
