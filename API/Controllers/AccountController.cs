using System;
using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class AccountController(AppDbContext context): BaseApiController
{
  [HttpPost("register")]
}
