using Marsen.NetCore.DDD.Application.Common.Interfaces;
using System;

namespace Marsen.NetCore.DDD.WebUI.IntegrationTests
{
    public class TestDateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
