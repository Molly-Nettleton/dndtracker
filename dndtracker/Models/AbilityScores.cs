namespace dndtracker.Models;

public class AbilityScores : IDbItem<int>
{
  public int Id { get; set; }
  public int Str { get; set; }
  public int Dex { get; set; }
  public int Con { get; set; }
  public int Intel { get; set; }
  public int Wis { get; set; }
  public int Char { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}