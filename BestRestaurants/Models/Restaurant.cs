namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public string Name { get; set; }
    public int PricePoint { get; set; }
    public bool Vegan { get; set; }
    public int RestaurantId { get; set; }
    public int CuisineId { get; set; }

    public virtual Cuisine Cuisine { get; set; }
  }
}