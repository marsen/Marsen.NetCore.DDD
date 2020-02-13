using Marsen.NetCore.DDD.Application.Common.Interfaces;
using System;

namespace Marsen.NetCore.DDD.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
