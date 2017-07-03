using System;

namespace RT.Comb
{
    public interface IClock
    {
        DateTime UtcNow { get; }
    }

    public class SystemClock : IClock
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }

    public class FakeClock : IClock
    {
        public FakeClock(DateTime frozenTime)
        {
            FrozenTime = frozenTime;
        }

        public DateTime FrozenTime { get; }

        public DateTime UtcNow => FrozenTime;
    }
}