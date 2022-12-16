using System;

namespace TourManager.DAL.Infrastructure.Interfaces
{
    public interface IDbFactory : IDisposable
    {
        TourContext Init();
    }
}
