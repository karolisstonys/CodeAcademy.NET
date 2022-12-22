using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO;
using L05_Tasks_MSSQL.Models.DTO.UserDto;
using L05_Tasks_MSSQL.Repository.IRepository;
using L05_Tasks_MSSQL.Services.IServices;
using System.Linq.Expressions;
using System.Text;

namespace L05_Tasks_MSSQL.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly BookStoreContext _db;
        private readonly IPasswordService _passwordService;
        private readonly IJwtService _jwtService;
        private readonly IUserAdapter _userAdapter;

        private readonly LoginResponse _emptyTokenAndNullUser = new LoginResponse
        {
            Token = "",
            User = null
        };

        public UserRepository(BookStoreContext db, 
                              IConfiguration conf, 
                              IPasswordService passwordService, 
                              IJwtService jwtService,
                              IUserAdapter userAdapter)
        {
            _db = db;
            _passwordService = passwordService;
            _jwtService=jwtService;
            _userAdapter = userAdapter;
        }

        public bool IsUniqueUser(string username) => !_db.Users.Any(u => u.Username == username);

        public LoginResponse Login(LoginRequest loginRequest)
        {
            var inputPastwordBytes = Encoding.UTF8.GetBytes(loginRequest.Password);
            var user = _db.Users.FirstOrDefault(u => u.Username.ToLower() == loginRequest.Username.ToLower());

            if (user == null) return _emptyTokenAndNullUser;

            if (!_passwordService.VerifyPasswordHash(loginRequest.Password, user.PasswordHash, user.PasswordSalt)) return _emptyTokenAndNullUser;

            var token = _jwtService.GetJwtToken(user.Id, user.Role);

            LoginResponse loginResponse = new()
            {
                Token = token,
                User = _userAdapter.Bind(user)
            };

            return loginResponse;
        }

        public RegistrationResponse Register(RegistrationRequest registrationRequest)
        {
            _passwordService.CreatePasswordHash(registrationRequest.Password, out byte[] hash, out byte[] salt);

            User user = new()
            {
                Username = registrationRequest.Username,
                PasswordHash = hash,
                PasswordSalt = salt,
                FullName = registrationRequest.FullName,
                Role = registrationRequest.Role,
                Created = DateTime.Now,
                Updated = DateTime.Now
            };

            RegistrationResponse registrationResponse = new()
            {
                Username = registrationRequest.Username,
                FullName = registrationRequest.FullName,
                Role = registrationRequest.Role
            };

            _db.Users.Add(user);
            _db.SaveChanges();

            return registrationResponse;
        }

        public List<GetUserDto> GetAll(Expression<Func<User, bool>>? filter = null)
        {
            IQueryable<User> users = _db.Users;
            if (filter != null) users = _db.Users.Where(filter);

            var userDto = new List<GetUserDto>();
            foreach (var user in users)
            {
                userDto.Add(new GetUserDto()
                {
                    UserId = user.Id,
                    FullName = user.FullName,
                    Role = user.Role,
                    TakenLibraryBooks = user.TakenLibraryBooks
                });

            }
            return userDto;
        }

        public GetUserDto Get(Expression<Func<User, bool>> filter)
        {
            User user = _db.Users.Where(filter).FirstOrDefault();
            var userDto = new GetUserDto()
            {
                UserId = user.Id,
                FullName = user.FullName,
                Role = user.Role,
                TakenLibraryBooks = user.TakenLibraryBooks,
                BooksNotReturnedInTime = user.BooksNotReturnedInTime,
                TotalDebt = user.TotalDebt
            };
            return userDto;
        }

        public void UpdateTakenLibraryBooks(int userId, int modifier)
        {
            User user = _db.Users.First(u => u.Id == userId);
            user.TakenLibraryBooks += modifier;
            _db.Users.Update(user);
            _db.SaveChanges();
        }

        public void UpdateBooksNotReturnedInTimeAndTotalDebt(int userId, int booksNotReturnedInTime, double totalDebt)
        {
            User user = _db.Users.First(u => u.Id == userId);
            user.BooksNotReturnedInTime = booksNotReturnedInTime;
            user.TotalDebt = totalDebt;
            _db.Users.Update(user);
            _db.SaveChanges();
        }

        public async Task Update(GetUserDto userDto)
        {
            try
            {
                User user = _db.Users.First(u => u.Id == userDto.UserId);
                user.TakenLibraryBooks = userDto.TakenLibraryBooks;
                user.BooksNotReturnedInTime = userDto.BooksNotReturnedInTime;
                user.TotalDebt = userDto.TotalDebt;
                user.LastLogin = userDto.LastLogin;
                user.Points = userDto.Points;

                _db.Users.Update(user);
                await _db.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
