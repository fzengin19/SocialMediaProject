using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Text;

namespace Business.Abstract
{

    public interface IAuthService
    {
        IResult UserExists(string email);
        IResult Delete(User user);
        IResult Update(User user);
        IResult UpdateProfilePictures(IFormFile formFile, int userDetailId);
        IDataResult<List<User>> SearchUser(string searchText);
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IDataResult<AccessToken> CreateAccessToken(User user);
        
    }
}
