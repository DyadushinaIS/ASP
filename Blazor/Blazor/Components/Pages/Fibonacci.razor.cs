namespace Blazor.Components.Pages
{
	public partial class Fibonacci
	{
		int amount = 0;
		string result = "";

		void Fibonacci_row()
		{
			int n1 = 1;
			int n2 = 1;
			
			if (amount == 1)
				result += "F1=1 ";
			if (amount == 2)
				result += "F2=1 ";
			if (amount>2)
			{
				for (int i = 3;  i < amount; i++)
				{
					int n3 = n1 + n2;
					result = result + "F" + i + "=" + n3+"\n "; 
					n1=n2;
					n2=n3;
				}
			}
		}
	}
}
