using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MaskinparkBlazor.Shared.Entities;

namespace MaskinparkBlazor.API.Data
{
    public class APIContext : DbContext
    {
        public APIContext (DbContextOptions<APIContext> options)
            : base(options)
        {
        }

        public DbSet<MaskinparkBlazor.Shared.Entities.Machine> Machine { get; set; } = default!;
    }
}
