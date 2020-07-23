using FitnessWebAPI.Contexts;
using FitnessWebAPI.Services.Repositories;
using System;

namespace FitnessWebAPI.Services.UnitsOfWork
{
    public class CardUnitOfWork : ICardUnitOfWork
    {
        private readonly FitnessContext _context;

        public CardUnitOfWork(FitnessContext context, ICardRepository cards, IValabilityRepository valability)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            Cards = cards ?? throw new ArgumentNullException(nameof(context));
            Valability = valability ?? throw new ArgumentNullException(nameof(context));
        }

        public ICardRepository Cards { get; }

        public IValabilityRepository Valability { get; }

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