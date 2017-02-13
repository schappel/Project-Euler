<Query Kind="Program" />

void Main()
{
	TriangleNumbers(int.MaxValue).Where( t => DivisorCount(t) >= 500 ).First().Dump();
	
	//Divisors(7).Dump();
}

IEnumerable<int> TriangleNumbers( int max )
{
	int current = 1;
	int result = 0;
	while (current <= max)
	{
		result += current;
		yield return result;
		current++;
	}
}

IEnumerable<int> Divisors(int value)
{
	for (int i = 1; i <= value; i++)
	{
		if( value % i == 0 ) yield return i;
	}
}

int DivisorCount(int value)
{
	var result = 0;
	int sqrt = (int)Math.Sqrt(value);

	for (int i = 1; i <= sqrt; i++)
	{
		if (value % i == 0)
		{
			result += 2; // a * b  b * a
		}
	}
	//Correction if the number is a perfect square
	if (sqrt * sqrt == value)
	{
		result--;
	}
	string.Format( "{0} - {1}", value, result).Dump();
	return result;
}

// Define other methods and classes here
