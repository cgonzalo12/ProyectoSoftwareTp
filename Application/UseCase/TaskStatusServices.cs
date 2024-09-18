using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase
{
    public class TaskStatusServices : ITaskStatusServices
    {
        private readonly ITaskStatusQuery _query;

        public TaskStatusServices(ITaskStatusQuery query)
        {
            _query = query;
        }

        public async Task<List<Domain.Entities.TaskStatus>> GetAllTaskStatus()
        {
            return await _query.GetAllTaskStatus();
        }
    }
}
