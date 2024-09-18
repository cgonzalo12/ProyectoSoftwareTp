using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase
{
    public class UserServices : IUserServices
    {
        private readonly IUserQuery _query;

        public UserServices(IUserQuery query)
        {
            _query = query;
        }

        public async Task<List<Users>> GetAllUsers()
        {
            return await _query.GetAllUsers();
        }
    }
}
