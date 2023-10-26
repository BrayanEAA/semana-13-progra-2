using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
public class Context : DbContext
{
    public DbSet<Student> estudiante { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-J91J8C7;Database=Progra2; Trusted_Connection = SSPI; MultipleActiveResultSets = true; Trust Server Certificate = true; ");
    }
}

