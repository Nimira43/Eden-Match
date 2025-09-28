using System.Security.Claims;
using System.Text;
using API.Entities;
using API.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace API.Services;

public class TokenService(IConfiguration config) : ITokenService
{
  public string CreateToken(AppUser user)
  {
    var tokenKey = config["TokenKey"] ?? throw new Exception("Cannot get token key");
    if (tokenKey.Length < 64)
      throw new Exception("Your token key needs to be >= 64 characters.");
    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey));

    var claims = new List<Claim>
    {
      
    }

  }
}
