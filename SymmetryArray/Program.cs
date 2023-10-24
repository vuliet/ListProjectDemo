var array = new int[] { 0, 1, 2, 3, 5, 5, 3, 2, 1, 0 };

bool isSymmetry = true;

for (int i = 0; i < array.Length / 2; i++)
{
    if (array[i] != array[array.Length - 1 - i])
    {
        Console.WriteLine("Mang khong doi xung");
        isSymmetry = false;
        break;
    }
}

if (isSymmetry)
    Console.WriteLine("Mang doi xung");

Console.ReadLine();

