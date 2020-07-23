using FitnessWebAPI.Contexts;
using FitnessWebAPI.Entities;
using System;

namespace FitnessWebAPI.Services.Repositories
{
    public class ValabilityRepository : Repository<Valability>, IValabilityRepository
    {
        private readonly FitnessContext _context;

        public ValabilityRepository(FitnessContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}

