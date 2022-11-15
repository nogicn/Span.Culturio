using AutoMapper;
using Span.Culturio.Api.Data;
using Span.Culturio.Api.Data.Entities;
using Span.Culturio.Api.Models;
using Span.Culturio.Api.Services.Auth;
using Span.Culturio.Api.Services.User;

namespace Span.Culturio.Api.Services.Auth

{
    public class AuthService : IAuthService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        //private readonly UserService _userService;
        //private RegisterUserDto userDto;
        public AuthService(DataContext context, IMapper mapper)//, UserService userService)
        {
            _context = context;
            _mapper = mapper;
           // _userService = userService;
        }

        public Task<LoginDto> loginUser(LoginDto logindto)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDto> registerUser(UserDto userdto)
        {

             
             var userEnt = _mapper.Map<Data.Entities.User>(userdto);
             _context.Users.Add(userEnt);
             await _context.SaveChangesAsync();
            
            //throw new NotImplementedException();
            //await _userService.CreateUser(registeruserdto);
            return userdto;
        }
    }
}
