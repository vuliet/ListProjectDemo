using System.Collections.Concurrent;

namespace ConcurrentDictionary
{
    public class ConcurentProtect
    {
        private static readonly Dictionary<string, ConcurrentDictionary<string, long>> ProtectActionData = new();

        public static bool CheckHasProtectAction(string action, string entity, int circleInSeconds = 60)
        {
            var now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            lock (ProtectActionData)
            {
                if (ProtectActionData.TryGetValue(action, out var requests))
                {
                    if (requests.TryGetValue(entity, out var last))
                    {
                        if (last > now - TimeSpan.FromSeconds(circleInSeconds).TotalMilliseconds)
                            return true;

                        requests.TryRemove(entity, out long time);

                        if (requests.IsEmpty)
                            ProtectActionData.Remove(action);
                    }
                    else
                    {
                        requests.TryAdd(entity, now);
                    }
                }
                else
                {
                    var newRequests = new ConcurrentDictionary<string, long>();
                    newRequests.TryAdd(entity, now);
                    ProtectActionData.TryAdd(action, newRequests);
                }
            }

            return false;
        }
    }
}
