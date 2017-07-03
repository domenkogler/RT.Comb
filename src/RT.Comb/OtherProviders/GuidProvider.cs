using System;

namespace RT.Comb
{
    // Allows overriding how the random portion of Guids are created, in case
    // someone wants to use a different algorithm than Guid.NewGuid() or wants to decorate it before
    // the timestamp embedding (such as overriding another portion of the random bytes for some another
    // purpose).
    public interface IGuidProvider
    {
        Guid NewGuid();
    }

    public class DefaultGuidProvider : IGuidProvider
    {
        public Guid NewGuid() => Guid.NewGuid();
    }
}