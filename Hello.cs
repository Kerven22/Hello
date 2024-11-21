using System; 

namespace hello
{
	public class Program
	{
		public static void Main()
		{
			int[] arrayOne = {1,3,5,7,9}; 
			int [] arrayTwo, arrayThree; 
			arrayTwo = arrayOne; 
			arrayThree = new int[arrayOne.Length]; 
			for(int i =0; i<arrayOne.Length; i++)
			{
				arrayThree[i] = arrayOne[i];
			}

			for(int i =0; i<arrayThree.Length; i++)
			{
				Console.Write(arrayThree[i]);
			}
			Console.ReadLine(); 
			
		}
	}
}

