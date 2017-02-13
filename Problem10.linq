<Query Kind="Program" />

void Main()
{
	var result = Primes(2000000).Aggregate( (long)0, (r,p) => r + p );
	result.Dump();
}

IEnumerable<int> Primes(int max = Int32.MaxValue)
{
	if( max > 2 ) yield return 2;
	if( max > 3 ) yield return 3;
	var current = 5;
	while (current < max)
	{
		if (isPrime(current)) yield return current;
		current += 2;
	}
}

bool isPrime(int number)
{
	if (number == 1) return false;
	if (number == 2) return true;

	for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
	{
		if (number % i == 0) return false;
	}

	return true;
}