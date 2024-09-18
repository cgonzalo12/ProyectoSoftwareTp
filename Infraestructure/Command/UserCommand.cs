using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Command
{
    public class UserCommand:IUserCommand
    {
        private readonly AppDbContext _context;

        public UserCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task GetAllUsers()
        {
            await _context.Users.ToListAsync();
        }
    }
}
