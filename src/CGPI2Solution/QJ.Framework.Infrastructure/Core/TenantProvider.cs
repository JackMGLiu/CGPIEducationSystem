using System;

namespace QJ.Framework.Infrastructure.Core
{
    public class TenantProvider: ITenantProvider
    {
        public string CreateGuid()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}