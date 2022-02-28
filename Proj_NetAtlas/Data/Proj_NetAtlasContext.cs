#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetAtlas.Models;

namespace Proj_NetAtlas.Data
{
    public class Proj_NetAtlasContext : DbContext
    {
        public Proj_NetAtlasContext (DbContextOptions<Proj_NetAtlasContext> options)
            : base(options)
        {
        }

        public DbSet<NetAtlas.Models.Membre> Membre { get; set; }
    }
}
