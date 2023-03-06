using Estate_Expert.Models;

using Microsoft.EntityFrameworkCore;

namespace Estate_Expert.Data;

public class EstateExpertDbContext : DbContext
{
    public EstateExpertDbContext(DbContextOptions<EstateExpertDbContext> options) : base(options)
    {

    }
    public DbSet<StateModel> States { get; set; }
    public DbSet<CityModel> Cities { get; set; }
    public DbSet<UserDetailsModel> UserDetails { get; set; }
    public DbSet<SignInLogModel> SignInLogs { get; set; }
    public DbSet<EstateDetailModel> EstateDetail { get; set; }
    public DbSet<EstateStatusModel> EstateStatus { get; set; }

    public DbSet<EstateTypeModel> EstateTypes { get; set; }

}

