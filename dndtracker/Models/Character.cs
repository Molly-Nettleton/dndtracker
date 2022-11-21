namespace dndtracker.Models;
public class Character : IHasCreator
{

  public string Name { get; set; }
  public int Level { get; set; }
  public string[] Class { get; set; }
  public string[] SubClass { get; set; }
  public string Race { get; set; }
  public string Background { get; set; }
  public AbilityScore AbilityScore { get; set; }
  public string CreatorId { get; set; }
  public Profile Creator { get; set; }
  public int Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}

public class AbilityScore
{
  public int Str { get; set; }
  public int Dex { get; set; }
  public int Con { get; set; }
  public int Int { get; set; }
  public int Wis { get; set; }
  public int Cha { get; set; }
}