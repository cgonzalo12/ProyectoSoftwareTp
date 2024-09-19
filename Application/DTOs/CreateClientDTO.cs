﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CreateClientDTO
    {
        public Guid ClientID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        
        
    }

}
