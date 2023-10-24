var array = new int[] { 1, 2, 3, 4, 6, 10 };

var arrayAfterSort = array.Order().ToList();

var missingNumbers = new List<int>();

for (var i = 0; i < arrayAfterSort.Count; i++)
{
    if (i == arrayAfterSort.Count - 1)
        break;

    var nextNumber = arrayAfterSort[i + 1];

    var rangeBetweenTwoIndex = nextNumber - arrayAfterSort[i];
    if (rangeBetweenTwoIndex == 1)
        continue;

    for (var j = 1; j <= rangeBetweenTwoIndex - 1; j++)
        missingNumbers.Add(arrayAfterSort[i] + j);
}

Console.WriteLine($"Mang hien tai: {string.Join(",", array)}");

if (missingNumbers.Count > 0)
{
    Console.Write("Missing number is: ");

    foreach (var item in missingNumbers)
        Console.Write($"{item}, ");

    Console.WriteLine();
}

Console.ReadLine();


