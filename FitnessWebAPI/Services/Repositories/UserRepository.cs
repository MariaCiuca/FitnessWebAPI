using FitnessWebAPI.Contexts;
using FitnessWebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FitnessWebAPI.Services.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly FitnessContext _context;

        public UserRepository(FitnessContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<User> GetAvailableUsers()
        {
            return _context.Users
                .Where(u => (u.Deleted == false || u.Deleted == null))
                .ToList();
        }
    }
}