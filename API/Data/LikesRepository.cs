using System;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class LikesRepository (AppDbContext context) : ILikesRepository
{
  public void AddLike(MemberLike like)
  {
    context.Likes.Add(like);
  }

  public void DeleteLike(MemberLike like)
  {
    context.Likes.Remove(like);
  }

  public async Task<IReadOnlyList<string>> GetCurrentMemberLikeIds(string memberId)
  {
    return await context.Likes
      .Where(x => x.SourceMemberId == memberId)
      .Select(x => x.TargetMemberId)
      .ToListAsync();
  }

  public async Task<MemberLike?> GetMemberLike(string sourceMemberId, string targetMemberId)
  {
    return await context.Likes.FindAsync(sourceMemberId, targetMemberId);
  }

  public Task<IReadOnlyList<Member>> GetMemberLikes(string predicate, string memberId)
  {
    throw new NotImplementedException();
  }

  public Task<bool> SaveAllChanges()
  {
    throw new NotImplementedException();
  }
}
