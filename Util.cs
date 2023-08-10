using System.Diagnostics;

namespace SaCheats
{
    public static class Util
    {
        public static long nanoTime() => 10000L * Stopwatch.GetTimestamp() / 10000L * 100L;

        public static int mod(int x, int m)
        {
            return (x % m + m) % m;
        }
    }
}
