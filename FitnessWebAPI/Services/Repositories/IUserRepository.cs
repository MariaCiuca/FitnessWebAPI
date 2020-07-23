using FitnessWebAPI.Entities;
using System.Collections.Generic;

namespace FitnessWebAPI.Services.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetAvailableUsers();
    }
}
