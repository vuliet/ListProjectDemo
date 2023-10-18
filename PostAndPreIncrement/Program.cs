int count = 0;

Console.WriteLine("Count++ example: ");
// Sử dụng count++ trong vòng lặp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(count++); // In giá trị hiện tại của count, sau đó tăng count lên 1
}

Console.WriteLine("----------------------------------------");
count = 0;

Console.WriteLine("++Count example: ");
// Sử dụng ++count trong vòng lặp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(++count); // Tăng count lên 1, sau đó in giá trị mới của count
}

Console.ReadLine();