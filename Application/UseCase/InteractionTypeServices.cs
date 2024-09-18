using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase
{
    public class InteractionTypeServices : IInteractionTypeServices
    {
        private readonly IInteractionTypeQuery _query;

        public InteractionTypeServices(IInteractionTypeQuery query)
        {
            _query = query;
        }

        public async Task<List<InterationTypes>> GetAllInteractionType()
        {
            return await _query.GetAllInteractionType();
        }
    }
}
