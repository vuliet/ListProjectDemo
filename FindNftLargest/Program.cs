int[] numbers = { 12, 34, 5, 6, 23, 9, 65, 34, 23 };
int n = 2;

try
{
    int nthLargest = FindNthLargest(numbers, n);
    Console.WriteLine($"{n}th largest number in array is: {nthLargest}");
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}

static int FindNthLargest(int[] arr, int n)
{
    if (n <= 0 || n > arr.Length)
        throw new ArgumentException("Invalid value of n");

    int[] distinctArr = arr.Distinct().ToArray();
    Array.Sort(distinctArr);

    if (n > distinctArr.Length)
        throw new ArgumentException("n is greater than the number of distinct elements in the array");

    return distinctArr[distinctArr.Length - n];
}

Console.ReadLine();