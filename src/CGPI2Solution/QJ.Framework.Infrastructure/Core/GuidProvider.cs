using System;

namespace QJ.Framework.Infrastructure.Core
{
    public interface IGuidProvider
    {
        string CreateGuid();
    }

    public class GuidProvider : IGuidProvider
    {
        public string CreateGuid()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}