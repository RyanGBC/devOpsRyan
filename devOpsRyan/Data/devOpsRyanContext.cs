using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using devOpsRyan.Models;

namespace devOpsRyan.Data
{
    public class devOpsRyanContext : DbContext
    {
        public devOpsRyanContext (DbContextOptions<devOpsRyanContext> options)
            : base(options)
        {
        }

        public DbSet<devOpsRyan.Models.Aluno> Aluno { get; set; } = default!;
    }
}
