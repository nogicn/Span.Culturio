using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Span.Culturio.Api.Data;
using Span.Culturio.Api.Models;

namespace Span.Culturio.Api.Services.User
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private UserDto userDto;

        public UserService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<UserDto> CreateUser(RegisterUserDto registeruserdto)
        {
            userDto.Id = 0;
            userDto.firstName = registeruserdto.firstName;
            userDto.lastName = registeruserdto.lastName;
            userDto.username = registeruserdto.username;
            userDto.email = registeruserdto.email;
            userDto.password = registeruserdto.password;
            var userEnt = _mapper.Map<Data.Entities.User>(registeruserdto);
            userEnt.Id = 0;
            _context.Users.Add(userEnt);
            await _context.SaveChangesAsync();

            return userDto;
        }

        public async Task<UserDto> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            var userDto = _mapper.Map<UserDto>(user);

            return userDto;
        }

        public async Task<IEnumerable<UserDto>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            Console.WriteLine(users);
            var usersDto = _mapper.Map<List<UserDto>>(users);
            return usersDto;
        }
    }
}
