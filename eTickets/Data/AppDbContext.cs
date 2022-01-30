using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext:DbContext
    {
        //ye Constructor samaj ni aaya
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
    }
}
