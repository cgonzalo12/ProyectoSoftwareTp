using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Querys
{
    public class UserQuery : IUserQuery
    {
        public readonly AppDbContext _context;

        public UserQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Users>> GetAllUsers()
        {
            var listUsers = await _context.Users.ToListAsync();
            return listUsers;
        }
    }
}
