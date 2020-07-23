using FitnessWebAPI.Contexts;
using FitnessWebAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FitnessWebAPI.Services.Repositories
{
    public class CardRepository : Repository<Card>, ICardRepository
    {
        private readonly FitnessContext _context;

        public CardRepository(FitnessContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Card GetCardDetails(Guid cardId)
        {
            return _context.Cards
                .Where(b => b.ID == cardId && (b.Deleted == false || b.Deleted == null))
                .Include(b => b.Valability)
                .FirstOrDefault();
        }
    }
}