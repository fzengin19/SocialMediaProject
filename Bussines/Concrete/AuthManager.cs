using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Transaction;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserDal _userDal;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserDal userDal, ITokenHelper tokenHelper)
        {
            _userDal = userDal;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                JoinDate = DateTime.Now,
                LastSeen = DateTime.Now,
                Status = true
            };
            _userDal.Add(user);
            return new SuccessDataResult<User>(_userDal.Get(u => u.Email == user.Email), "Kayıt oldu");
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userDal.Get(u=> u.Email==userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>("Kullanıcı bulunamadı");
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>("Parola hatası");
            }
            userToCheck.LastSeen = DateTime.Now;
            _userDal.Update(userToCheck);
            return new SuccessDataResult<User>(userToCheck, "Başarılı giriş");
        }

        public IResult UserExists(string email)
        {   bool x = _userDal.Get(u => u.Email==email) != null;
            if (x)
            {
                return new ErrorResult("Bu e-mail adresi zaten kullanımda!!");
            }
            return new SuccessResult("Bu e-mail adresi ile kayıt bulunamadı");
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userDal.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, "Giriş başarılı Token oluşturuldu");
        }
        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.UserId == userId));
        }

        public IResult Delete(User user)
        {
            user = _userDal.Get(u => u.Email == user.Email);
            user.DeleteDate = DateTime.Now;
            _userDal.Delete(user);
            return new SuccessResult("Kullanıcı silindi");
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult("Kullanıcı güncellendi");
        }

        public IDataResult<List<User>> SearchUser(string searchText)
        {
            return new SuccessDataResult<List<User>>(_userDal.SearchUser(searchText));
        }

        [TransactionScopeAspect]
        public IResult UpdateProfilePictures(IFormFile formFile, int userId)
        {
            var user = _userDal.Get(ud => ud.UserId == userId); 
            if (user == null)
            {
                return new ErrorResult("Kullanıcı Bulunamadı");
            }

            //var user = _userDal.GetById(userDetailToUpdate.UserId);
            //if (user.Data == null)
            //{
            //    return new ErrorResult("Kullanıcı hesabı bulunamadı kritik hata!!");
            //}
            //FileHelper.Write(formFile, Paths.RootPath + user.ImagePath);
            return new SuccessResult();
        }
    }
}
