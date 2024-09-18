using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Services
{
    public class GuidGenerateServices : IGenerateID
    {
        public Guid GenerateID()
        {
            return Guid.NewGuid();
        }
    }
}
