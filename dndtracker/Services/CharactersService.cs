namespace dndtracker.Services;
public class CharactersService 
{
private readonly CharactersRepository _characterRepo;
public CharactersService(CharactersRepository characterRepo)
  {
    _characterRepo = characterRepo;
  }

  internal Character CreateCharacter(Character characterData)
  {
   return _characterRepo.CreateCharacter(characterData);
  }
}