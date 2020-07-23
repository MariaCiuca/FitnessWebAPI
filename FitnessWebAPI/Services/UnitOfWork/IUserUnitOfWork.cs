using FitnessWebAPI.Services.Repositories;
using System;

namespace FitnessWebAPI.Services.UnitsOfWork
{
    public interface IUserUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }

        int Complete();
    }
}