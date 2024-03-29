using System;
using System.Linq;

namespace Asses;

internal static class Program
{
	 static void Main()
	{

   Console.WriteLine("Jake Joshua B. Peñalosa");
   Console.Write("BSCpE 1-1");
   Console.Write("\n");
   
  for (int i = 1; i <= 100; i++)
  {
  if (i % 3 == 0 && i % 5 == 0)
 {
  Console.WriteLine("Hello Goodbye");
  }
  else if (i % 3 == 0)
  {
  Console.WriteLine("Hello");
  }
  else if (i % 5 == 0)
  {
  Console.WriteLine("Goodbye");
   }
  else
  {
  Console.WriteLine(i);
  }
  }
    }
}

	
