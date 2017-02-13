<Query Kind="Program" />

void Main()
{
	var result = FindResult(1000);
	(result.Item1 + result.Item2 + result.Item3).Dump();
	(result.Item1 * result.Item2 * result.Item3).Dump();
	
}

Tuple <int, int, int> FindResult(int max)
{
	for (int a = 1; a < 1000; a++)
	{
		for (int b = 0; b < 1000 - a; b++)
		{
			var c = 1000 - a - b;

			if ((a * a) + (b * b) == (c * c))
			{
				return new Tuple<int, int, int>(a, b, c);
			}
		}
	}
	return new Tuple<int, int, int>(-1, -1, -1);
}
