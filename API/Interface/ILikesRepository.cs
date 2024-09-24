using API.DTOs;
using API.Entities;
using API.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace API.Interfaces
{
   public interface ILikesRepository
   {
     Task<UserLike> GetUserLike(int sourceUserId, int TargetUserId);
     Task<AppUser> GetUserWithLikes(int userId);
     Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);
   
   }
}