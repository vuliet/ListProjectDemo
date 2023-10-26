using CopyObject;
using Newtonsoft.Json;

static T? DeepCopy<T>(T obj)
{
    if (obj is null)
        return default;

    string json = JsonConvert.SerializeObject(obj);
    T? copy = JsonConvert.DeserializeObject<T>(json);

    return copy;
}

var originObj = new AppModels()
{
    Id = 1,
    Name = "Thai"
};

var newObj = DeepCopy(originObj);

var listNewObj = new List<AppModels>();

listNewObj.Add(originObj);

listNewObj.First().Name = "Heo";

if (ReferenceEquals(originObj, listNewObj.First()))
    Console.WriteLine("obj1 và obj2 tham chieu den cung mot doi tuong.");
else
    Console.WriteLine("obj1 và obj2 tham chieu den doi tuong khác nhau.");

Console.ReadLine();