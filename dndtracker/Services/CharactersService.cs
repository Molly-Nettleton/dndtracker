namespace dndtracker.Services;
public class CharactersService : BaseRepository
{
  public CharactersService(IDbConnection db) : base(db)
  {
  }

  internal Character CreateCharacter(Character characterData)
  {
    throw new NotImplementedException();
  }
}