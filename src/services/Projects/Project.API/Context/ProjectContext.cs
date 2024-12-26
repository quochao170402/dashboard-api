using Microsoft.EntityFrameworkCore;

namespace Project.API.Context;

public class ProjectContext(DbContextOptions<ProjectContext> options) : DbContext(options)
{
    public DbSet<Entities.Project> Projects { get; set; }
}
