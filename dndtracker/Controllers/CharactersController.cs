namespace dndtracker.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CharactersController  : ControllerBase
{
  private readonly CharactersService _cs;
  private readonly Auth0Provider _auth0Provider;

  public CharactersController(CharactersService cs, Auth0Provider auth0Provider)
  {
    _cs = cs;
    _auth0Provider = auth0Provider;
  }

  [HttpPost]
  [Authorize]
  public async Task<ActionResult<Character>> CreateCharacter([FromBody] Character characterData)
  {
    try
    {
      var userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      characterData.CreatorId = userInfo.Id;
      Character character = _cs.CreateCharacter(characterData);
      return Ok(character);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }



}