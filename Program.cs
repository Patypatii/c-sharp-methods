// int[] a = { 1, 2, 3, 4, 5 };

// Console.WriteLine("Contents of Array:");
// PrintArray();

// void PrintArray()
// {
//     foreach (int x in a)
//     {
//         Console.Write($"{x} ");
//     }
//     Console.WriteLine();
// }


// //method exexcution
// Console.WriteLine("Before calling a method");
// SayHello();
// Console.WriteLine("After calling a method");

// void SayHello()
// {
//     Console.WriteLine("Hello World!");
// }

//method to display random numbers
void DisplayRandomNumbers()
{
    Random random = new Random();
    for (int i = 0; i <= 5; i++)
    {
        Console.Write($"{random.Next(1, 100)} ");
    }
}