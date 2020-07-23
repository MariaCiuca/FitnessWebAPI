using FitnessWebAPI.Services.Repositories;
using System;

namespace FitnessWebAPI.Services.UnitsOfWork
{
    public interface ICardUnitOfWork : IDisposable
    {
        ICardRepository Cards { get; }

        IValabilityRepository Valability { get; }

        int Complete();
    }
}