using Microsoft.EntityFrameworkCore;

namespace KarmaAspNet.Data
{
    public class KarmaDbContext:DbContext
    {
        public KarmaDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
