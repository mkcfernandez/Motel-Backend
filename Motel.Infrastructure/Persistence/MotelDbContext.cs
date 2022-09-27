using Microsoft.EntityFrameworkCore;
using Motel.Domain.Entities;
using Motel.Domain.Entities.Common;

namespace Motel.Infrastructure.Persistence
{
    public class MotelDbContext : DbContext
    {
        public MotelDbContext(DbContextOptions<MotelDbContext> options) : base(options)
        {

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainModel>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.CreatedBy = "system";
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        entry.Entity.LastModifiedBy = "system";
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<MovimientoHabitacionModel>? movimientosHabitacion { get; set; }
    }
}
