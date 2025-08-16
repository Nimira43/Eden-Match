using System;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class AccountController(AppDbContext context) : BaseApiController
{
  [HttpPost("register")]
  public async Task<ActionResult<AppUser>>
}
