using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models;

public class TravelApiContext : DbContext
{
  public DbSet<Destination> Destinations { get; set; }

  public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
  {
  }

  protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<Destination>().HasData(
      new Destination { DestinationId=1, 
                        Location="Montreal",
                        State="Quebec",
                        Country="Canada", 
                        Review="Lovely city, great architecture and food, best to visit in summer (winter is cold).",
                        Rating=4
                      },
      new Destination { DestinationId=2, 
                        Location="Vancouver",
                        State="B.C.",
                        Country="Canada",  
                        Review="Great place, especially if you love a mix of outdoors and urban life. Delicious food and shopping, mild weather in the winter.",
                        Rating=5
                      },
      new Destination { DestinationId=3, 
                        Location="Sydney", 
                        State="NSW",
                        Country="Australia", 
                        Review="Such a fun city. All the usual tourist destinations a must, but head north too. Manly is beautiful. Or East to the Blue Mountains for the coolest caves.",
                        Rating=5
                      },
      new Destination { DestinationId=4, 
                        Location="Honolulu", 
                        State="Hawaii",
                        Country="USA", 
                        Review="Love Hawaii, and a Honolulu is a must stop, but don't spend all your time here. Visit other islands first, then a couple nights here. Plan a trip to Pearl Harbor, hike Diamond Head, and head out to North Shore.",
                        Rating=3
                      },
      new Destination { DestinationId=5, 
                        Location="Bucerias", 
                        State="Nayarit",
                        Country="Mexico", 
                        Review="Great little town. Personally like the pace better than Puerto Vallarta. And the food is excellent. Try the burrito wherever you go. Relaxing vacation.",
                        Rating=4
                      }
    );
  }
}
