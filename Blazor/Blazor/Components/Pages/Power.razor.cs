using System.Numerics;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Blazor.Components.Pages
{
	public partial class Power
	{
		// Получаем число
		int number = 1;
		// Получаем степень
		int exponent = 1;
		BigInteger result = 1;
		void Power_result()
		{
			// Возводим в степень через умножение
			result = 1;
			for (int i = 1; i <= exponent; i++)
			{ result *= number; }
		}
	}			
}
				
	