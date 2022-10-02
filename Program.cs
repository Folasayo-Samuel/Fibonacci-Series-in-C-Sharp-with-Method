using System;

namespace FibonacciSeries
{
	public class Program
	{
		
		static long[] numbers;
		static long Fib(int n)
		{
			if(0 == numbers[n])
				numbers[n] = Fib(n - 1) + Fib(n - 2);
			return numbers[n];
		}
		public static void Main(string[]args)
		{
			Console.Write("n = ");
			int n = int.Parse(Console.ReadLine());
			numbers = new long[n + 2];
			numbers[1] = 1;
			numbers[2] = 1;
			long result = Fib(n);
			Console.WriteLine($"fib({n}) = {result}");
            Console.ReadKey();
        }
	}
}