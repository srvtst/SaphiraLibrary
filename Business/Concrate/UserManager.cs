using Business.Abstract;
using Business.FluentValidation;
using Core.Utilities.Security.Hashing;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public User Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = GetByMail(userForLoginDto.Email);

            if (userToCheck == null)
            {
                throw new Exception("Kullanıcı sistemde mevcut değil");
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                throw new Exception("Şifre hatalı");
            }
            return userToCheck;
        }
        
        public User Register(UserForRegisterDto userForRegisterDto, string password)
        {
            UserValidator userValidator = new UserValidator();
            ValidationResult result = userValidator.Validate(userForRegisterDto);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }

            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userDal.Add(user);
            return user;
        }
    }
}