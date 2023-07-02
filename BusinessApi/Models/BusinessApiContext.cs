using Microsoft.EntityFrameworkCore;

namespace BusinessApi.Models
{
  public class BusinessApiContext : DbContext
  {
    public DbSet<Business> Businesses { get; set; }

    public BusinessApiContext(DbContextOptions<BusinessApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
        .HasData(
          new Business { BusinessId = 1, Name = "Pierres Bakery", Address = "1234 Fifth Street WA", Description = "Bakery", Rating = 4.7999999999999998, Review = "Very tastey!" },
          new Business { BusinessId = 2, Name = "Silly String Factory", Address = "1234 Fifth Street WA", Description = "Factory", Rating = 2.2000000000000002, Review = "Too much work" },
          new Business { BusinessId = 3, Name = "Hair Salon", Address = "1234 Fifth Street WA", Description = "Hair Salon", Rating = 3.3999999999999999, Review = "I got an awesome mullet!" },
          new Business { BusinessId = 4, Name = "Goodboy's Pizza Parlor", Address = "1234 Fifth Street WA", Description = "Pizza Parlor", Rating = 5.0, Review = "Best Pizza In The World!" },
          new Business { BusinessId = 5, Name = "James J. Jameson's Treats1234 Fifth Street WA", Address = "1234 Fifth Street WA", Description = "Dessert Shop", Rating =  0.5, Review = "Wouldnt give me a free treat:(" }
        );
    }
  }
}
