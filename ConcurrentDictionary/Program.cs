using ConcurrentDictionary;

ConcurentProtect.CheckHasProtectAction("test", "1", 5);
ConcurentProtect.CheckHasProtectAction("test", "2", 5);

Task.Delay(5000).Wait();

ConcurentProtect.CheckHasProtectAction("test", "1", 5);
ConcurentProtect.CheckHasProtectAction("test", "2", 5);
