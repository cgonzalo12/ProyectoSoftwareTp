using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskStatus = Domain.Entities.TaskStatus;

namespace Application.Interfaces
{
    public interface ITaskStatusServices
    {
        Task<List<TaskStatus>> GetAllTaskStatus();
    }
}

