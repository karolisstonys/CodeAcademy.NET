﻿using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO;
using L05_Tasks_MSSQL.Models.DTO.UserDto;
using System.Linq.Expressions;

namespace L05_Tasks_MSSQL.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        LoginResponse Login(LoginRequest loginRequest);
        RegistrationResponse Register(RegistrationRequest registrationRequest);
        public List<GetUserDto> GetAll(Expression<Func<User, bool>>? filter = null);
        public GetUserDto Get(Expression<Func<User, bool>> filter = null);
        public void UpdateTakenLibraryBooks(int userId, int modifier);
        void UpdateBooksNotReturnedInTime(int userId, int booksNotReturnedInTime);
    }
}
