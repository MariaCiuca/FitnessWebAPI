using FitnessWebAPI.Entities;
using System;

namespace FitnessWebAPI.Services.Repositories
{
    public interface ICardRepository : IRepository<Card>
    {
        Card GetCardDetails(Guid cardId);
    }
}
