<Query Kind="Program" />

void Main()
{

Fibonacci(4000000).Aggregate( 0, (total, i) => i % 2 == 0 ? total + i : total ).Dump();
}

IEnumerable<int> Fibonacci( int max )
{
	var previous = 1;
	var current = 1;
	while( current <= max )
	{
		yield return current;
		var next = current + previous;
		previous = current;
		current = next;
	}
}

