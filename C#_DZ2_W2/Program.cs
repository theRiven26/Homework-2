Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
int count = 0;
int number1 = number;
int divider = 10;

for (int i = 10; number1 > 0; i = i * 10)
{
	number1 = number1 - number1 % i;
	count++;
}
if (count > 2)
{
	while (count - 2 > 0)
	{
		number1 = number % divider * 10 / divider;
		divider = divider * 10;
		count--;
	}

	Console.WriteLine(number1);
}
else
{
	Console.WriteLine("no third digit");
}

