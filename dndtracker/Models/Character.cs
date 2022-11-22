namespace dndtracker.Models;
public class Character : IHasCreator
{


  public string Name { get; set; }
  public int Level { get; set; }
  public int Hp { get; set; }
  public string Img { get; set; }
  public string Classes { get; set; }
  public string SecondClasses { get; set; }
  public string SubClass { get; set; }
  public string Race { get; set; }
  // public AbilityScores AbilityScores { get; set; }
  public string Background { get; set; }
  public string CreatorId { get; set; }
  public Profile Creator { get; set; }
  public int Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  // Populated

}
