namespace dndtracker.Models;
public class Character : IHasCreator
{

  public int Id { get; set; }
  public string Name { get; set; }
  public int Level { get; set; }
  public int Hp { get; set; }
  public string Img { get; set; }
  public List<Classes> Classes { get; set; }
  public List<Classes> SecondClasses { get; set; }
  public string SubClass { get; set; }
  public string Race { get; set; }
  // public AbilityScores AbilityScores { get; set; }
  public string Background { get; set; }
  // Populated
  public string CreatorId { get; set; }
  public Profile Creator { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}
