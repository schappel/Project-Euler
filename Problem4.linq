<Query Kind="Program" />

void Main()
{
	var result = 0;
	for (int x = 100; x < 1000; x++)
	{
		for (int y = 100; y < 1000; y++)
		{
			var test = x * y;
			if (test > result && test == reverseNumber(test))
			{
				result = test;
			}
		}
	}
	result.Dump();
}

bool isPalidrome(int input)
{
	return false;
}

int reverseNumber( int input )
{
	char[] charArray = input.ToString().ToCharArray();
	Array.Reverse(charArray);
	return int.Parse( new string(charArray) );
}