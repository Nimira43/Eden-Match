using API.Entities;
using API.Interfaces;

namespace API.Services;

public class TokenService(IConfiguration config) : ITokenService
{
  public string CreateToken(AppUser user)
  {
    var tokenKey = config["TokenKey"];
  }
}
