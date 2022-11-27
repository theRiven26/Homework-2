Console.Write("Enter three digit number: ");
int number = int.Parse(Console.ReadLine());
int number1 = (number % 100) / 10;
Console.WriteLine(number1);
