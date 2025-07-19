using System;

namespace API.Entities;

public class AppUser
{
  public string Id { get; set; } = Guid.NewGuid().ToString();
}
