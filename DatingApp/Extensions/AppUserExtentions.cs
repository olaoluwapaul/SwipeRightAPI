using DatingApp.DTOs;
using DatingApp.Entities;
using DatingApp.Interfaces;

namespace DatingApp.Extensions
{
    public static class AppUserExtentions
    {
        public static UserDto ToDto(this AppUser user, ITokenService tokenService)
        {
            return new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                ImageUrl = user.ImageUrl,
                DisplayName = user.DisplayName,
                Token = tokenService.CreateToken(user)
            };
        }
    }
}
