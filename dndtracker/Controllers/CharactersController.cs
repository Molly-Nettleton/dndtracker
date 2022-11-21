namespace dndtracker.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CharactersController : IController
{
  private readonly CharactersService _cs;

  public CharactersController(Auth0Provider auth0Provider) : base(auth0Provider)
  {
  }

 

//   [HttpPost]
//  [Authorize]
//   public async Task<ActionResult<Character>> CreateCharacter([FromBody] Character characterData)
//   {
//     try
//     {
//       var userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
//       Character character = _rs.CreateCharacter(characterData);
//       return Ok(character);
//     }
//     catch (Exception e)
//     {
//       return BadRequest(e.Message);
//     }
//   }


  
}