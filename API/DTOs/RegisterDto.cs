using System;

namespace API.DTOs;

public class ResgisterDto
{
  public required string DisplayName { get; set; }
  public required string Email { get; set; }
  public required string Password { get; set; }
}
