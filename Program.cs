using static System.Console;

WriteLine("Enter int: ");
string? input1 = ReadLine();

try
{
	int num = int.Parse(input1);
	string cardinality = "";
	int lastDigit = num % 100;
	if (num < 0)
	{
		Console.WriteLine($"negative ordinal number doesn't exists");
	}
	else if (num == 0)
	{
		WriteLine("zero doesn't have ordinality!!");
	} 

	else
	{
		switch (lastDigit)
		{
			case 11:
			case 12:
			case 13:
				cardinality = "th";
				break;
			default:
				lastDigit = num % 10;
				cardinality = lastDigit switch
				{
					1 => "st",
					2 => "nd",
					3 => "rd",
					_ => "th"
				};
				break;
		}
		WriteLine(num + cardinality);
	}
 }
catch
{
	WriteLine("Wrong input, please enter int");
}

