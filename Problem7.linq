<Query Kind="Program" />


void Main()
{
	Primes().Skip(10000).Take(1).Dump();

}

IEnumerable<int> Primes()
{
	var limit = 2;
	while (limit < Int32.MaxValue)
	{
		if( isPrime(limit) ) yield return limit;
		limit++;
	}
}

bool isPrime(int value)
{
	if( value < 2 ) return false;
	if( value <= 3 ) return true;
	var upper = Math.Ceiling(Math.Sqrt(value));
	foreach (var test in Enumerable.Range(2, (int)upper))
	{
		if( value % test == 0 ) return false;
	}
	return true;
}