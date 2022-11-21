namespace dndtracker.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CharactersController : ControllerBase
{
  private readonly Auth0Provider _auth0Provider;
  public CharactersController(Auth0Provider auth0Provider)
  {
    _auth0Provider = auth0Provider;
  }


  
}