using System;

namespace QJ.Framework.Infrastructure.Core
{
    public interface IGuidCodeProvider
    {
        string CreateGuid();
    }

    public class GuidCodeProvider : IGuidCodeProvider
    {
        public string CreateGuid()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}