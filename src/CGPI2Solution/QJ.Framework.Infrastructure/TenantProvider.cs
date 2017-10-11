using System;
using QJ.Framework.Infrastructure.Core;

namespace QJ.Framework.Infrastructure
{
    public class TenantProvider: ITenantProvider
    {
        public string CreateGuid()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}