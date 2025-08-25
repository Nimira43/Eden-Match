using System;
using System.Security.Cryptography;
using System.Text;
using API.Data;
using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class AccountController(AppDbContext context) : BaseApiController
{
  [HttpPost("register")]
  public async Task<ActionResult<AppUser>> Register(RegisterDto registerDto)
  {
    using var hmac = new HMACSHA512();

    var user = new AppUser
    {
      DisplayName = displayName,
      Email = email,
      PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)),
      PasswordSalt = hmac.Key
    };
    context.Users.Add(user);
    await context.SaveChangesAsync();
    return user;
  } 
}
