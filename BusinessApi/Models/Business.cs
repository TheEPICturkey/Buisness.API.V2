using System.ComponentModel.DataAnnotations;

namespace BusinessApi.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }
    public double Rating { get; set; }
    public string Review { get; set; }
  }
}