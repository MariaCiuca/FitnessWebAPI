using FitnessWebAPI.Contexts;
using FitnessWebAPI.Services.Repositories;
using System;

namespace FitnessWebAPI.Services.UnitsOfWork
{
    public class UserUnitOfWork : IUserUnitOfWork
    {
        private readonly FitnessContext _context;

        public UserUnitOfWork(FitnessContext context, IUserRepository users)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            Users = users ?? throw new ArgumentNullException(nameof(context));
        }

        public IUserRepository Users { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}