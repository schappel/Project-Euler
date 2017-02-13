<Query Kind="Program" />

void Main()
{
	Int64 input = 600851475143;
	Enumerable.Range(0, ((int)Math.Sqrt(input)) * 2 ).Where( i => isPrime(i) && isPrimeFactor(input, i)  ).Dump();
}

bool isPrime(int number)
{

    if (number == 1) return false;
    if (number == 2) return true;

    for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)  {
       if (number % i == 0)  return false;
    }

    return true;
}

bool isPrimeFactor( Int64 number, int prime )
{
	return prime > 0 && number % prime == 0;
}