namespace HIDVIWINCS
{
    using System.Collections.Generic;
    using System.Linq;
    using StackExchange.Redis;

    public static class RedisValueExtensions
    {
        public static byte FirstByte(this RedisValue value)
        {
            return ((byte[]) value)[0];
        }

        public static HashEntry[] Entries(this IDictionary<string, byte> hash)
        {
            return hash.Select(v => new HashEntry(v.Key, new[] {v.Value})).ToArray();
        }
    }
}