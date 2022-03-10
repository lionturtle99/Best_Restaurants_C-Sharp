using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Cuisine
  {
    public string Type { get; set; }
    public int SpiceLevel { get; set; }
    public string Continent { get; set; }
    public int CuisineId { get; set; }

    public virtual ICollection<Restaurant> Restaurants { get; set; }

    public Cuisine()
    {
        this.Restaurants = new HashSet<Restaurant>();
    }

  }
}