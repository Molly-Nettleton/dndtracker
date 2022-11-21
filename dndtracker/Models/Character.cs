namespace dndtracker.Models;
public class Character : IHasCreator
{

  public string Name { get; set; }
  public int Level { get; set; }
  public int Hp { get; set; }
  public string img { get; set; }
  public string Classes { get; set; }
  public string SecondClass { get; set; }
  public string[] SubClasses { get; set; }
  public string Race { get; set; }
  public AbilityScores AbilityScores { get; set; }
  public string Background { get; set; }

  

  // Populated
  public string CreatorId { get; set; }
  public Profile Creator { get; set; }
  public int Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}


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