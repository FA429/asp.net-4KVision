using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Utils;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private IConfiguration _config;
        private IMapper _mapper;

        public UserService(IUserRepository userRepository, IConfiguration config, IMapper mapper)
        {
            _userRepository = userRepository;
            _config = config;
            _mapper = mapper;
        }

        public UserReadDto SignUp(UserCreateDto user)
        {
            byte[] pepper = Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]!);
            PasswordUtils.HashPassword(user.Password, out string hashedPassword, pepper);
            user.Password = hashedPassword;
            User mappedUser = _mapper.Map<User>(user);
            User newUser = _userRepository.CreateOne(mappedUser);
            UserReadDto readerUser = _mapper.Map<UserReadDto>(newUser);
            return readerUser;
        }

        public string? Login(UserLogInDto user)
        {
            IEnumerable<User>? users = _userRepository.FindAll(0, 0);
            User? isUser = users.FirstOrDefault(u => u.Email == user.Email);
            if (isUser == null) return null;
            byte[] pepper = Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]!);
            bool isCorrect = PasswordUtils.VerifyPassword(user.Password, isUser.Password, pepper);
            if (!isCorrect) return null;

            //Create Token 
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, isUser.Name),
                new Claim(ClaimTypes.Role, isUser.Role.ToString()),
                new Claim(ClaimTypes.Email, isUser.Email),
                new Claim(ClaimTypes.NameIdentifier, isUser.Id.ToString()),
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:SigningKey"]!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"]!,
                audience: _config["Jwt:Audience"]!,
                claims: claims,
                expires: DateTime.Now.AddDays(7),
                signingCredentials: creds
                );
            var tokenSettings = new JwtSecurityTokenHandler().WriteToken(token);
            return tokenSettings;
        }

        public bool DeleteOne(Guid userId)
        {
            var deleteUser = _userRepository.FindOne(userId);
            if (deleteUser == null) return false;
            _userRepository.DeleteOne(userId);
            return true;
        }

        public IEnumerable<UserReadDto> FindAll(int limit, int offset)
        {
            var users = _userRepository.FindAll(limit, offset);
            var usersRead = users.Select(user => _mapper.Map<UserReadDto>(user));
            return usersRead;

        }

        public UserReadDto? FindOne(Guid userId)
        {
            User? user = _userRepository.FindOne(userId);
            UserReadDto? userRead = _mapper.Map<UserReadDto>(user);
            return userRead;
        }

        public UserReadDto? UpdateOne(Guid userId, UserUpdateDto newValue)
        {
            var user = _userRepository.FindOne(userId);
            if (user == null) return null;
            user.Name = newValue.Name;
            user.Password = newValue.Password;
            user.Email = newValue.Email;
            user.Phone = newValue.Phone;
            _userRepository.UpdateOne(user);
            return _mapper.Map<UserReadDto>(user);
        }

    }
}