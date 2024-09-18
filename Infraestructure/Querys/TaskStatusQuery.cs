using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskStatus = Domain.Entities.TaskStatus;

namespace Infraestructure.Querys
{
    public class TaskStatusQuery : ITaskStatusQuery
    {
        public readonly AppDbContext _context;

        public TaskStatusQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TaskStatus>> GetAllTaskStatus()
        {
            var listTaskStatus = await _context.TaskStatus.ToListAsync();
            return listTaskStatus;
        }
    }
}
