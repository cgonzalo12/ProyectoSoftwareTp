using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Command
{
    public class TaskStatusCommand :ITaskStatusCommand
    {
        private readonly AppDbContext _context;

        public TaskStatusCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task GetAllTaskStatuss()
        {
            await _context.InterationTypes.ToListAsync();
        }
    }
}
