using Hyundai_Bolivia.Models;

namespace Microsoft.EntityFrameworkCore;

public class MiContext: DbContext
{
    public MiContext(DbContextOptions options): base(options)
    {

    }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Cliente> Cliente { get; set; }

}
