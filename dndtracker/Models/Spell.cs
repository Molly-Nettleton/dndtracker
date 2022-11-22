namespace dndtracker.Models;

public class Spell : IDbItem<int>
{
  public string Name { get; set; }
  public string Descriptions { get; set; }
  public string HigherLevel { get; set; }
  public string Range { get; set; }
  public string Components { get; set; }
  public string Material { get; set; }
  public string AOE { get; set; }

  public int Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}