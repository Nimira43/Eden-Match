using API.Entities;
using API.Interfaces;

namespace API.Services;

public class TokenService(IConfiguration config) : ITokenService
{
  public string CreateToken(AppUser user)
  {
    var tokenKey = config["TokenKey"];
    if (tokenKey.Length < 64) throw new Exception("Your token key needs to be  >= 64 characters.");
  }
}
