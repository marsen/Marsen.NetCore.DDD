using Marsen.NetCore.DDD.Application.Common.Interfaces;

namespace Marsen.NetCore.DDD.WebUI.IntegrationTests
{
    public class TestCurrentUserService : ICurrentUserService
    {
        public string UserId => "00000000-0000-0000-0000-000000000000";
    }
}
