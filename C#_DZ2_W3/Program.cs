Console.Write("enter the day of the week: ");
int day = int.Parse(Console.ReadLine());
if (day < 7)
{
	if (day == 6 || day == 7)
	{
		Console.WriteLine("it's a day off");
	}
	else
	{
		Console.WriteLine("it's not a day off");
	}
}
else
{
	Console.WriteLine("it's not a day of the week");
}