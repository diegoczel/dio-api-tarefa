using Microsoft.EntityFrameworkCore;
using P023_015_ApiTarefa.Models;

namespace P023_015_ApiTarefa.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(
            DbContextOptions<OrganizadorContext> options
        ) : base(options) 
        {
        }

        public DbSet<Tarefa>? Tarefas { get; set; }
    }
}
