using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hotel_EF.Models;

namespace Hotel_EF.Data
{
    public class Hotel_EFContext : DbContext
    {
        public Hotel_EFContext (DbContextOptions<Hotel_EFContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel_EF.Models.Cidade> Cidade { get; set; } = default!;

        public DbSet<Hotel_EF.Models.Cliente>? Cliente { get; set; }

        public DbSet<Hotel_EF.Models.Endereco>? Endereco { get; set; }

        public DbSet<Hotel_EF.Models.Hotel>? Hotel { get; set; }

        public DbSet<Hotel_EF.Models.Pacote>? Pacote { get; set; }

        public DbSet<Hotel_EF.Models.Passagem>? Passagem { get; set; }
    }
}
