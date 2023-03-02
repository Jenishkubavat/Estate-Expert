using Estate_Expert.Models;
using Microsoft.EntityFrameworkCore;

namespace Estate_Expert.Data;

    public class EstateExpertDbContext: DbContext
{
    public EstateExpertDbContext(DbContextOptions<EstateExpertDbContext>options) : base(options)
    {

    }
    public DbSet<StateModel> state { get; set; }
    public DbSet<CityModel> city { get; set; }
    public DbSet<UserDetailsModel>  userDetail { get; set; }
    public DbSet<SignInLogModel> signInLogs { get; set; }

    }

