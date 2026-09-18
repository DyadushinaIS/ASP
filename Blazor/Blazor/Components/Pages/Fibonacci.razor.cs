using System.Numerics;

namespace Blazor.Components.Pages
{
    public partial class Fibonacci
    {
        int amount = 0;
        string result = "";

        void Fibonacci_row()
        {
            BigInteger n1 = 1;
            BigInteger n2 = 1;

            if (amount == 1)
            {
                result = null;
                result += "F1=1 ";
            }
            if (amount == 2)
            {
                result = null;
                result += "F1=1 F2=1 ";
            }
            if (amount > 2)
            {
                result = null;
                result += "F1=1 F2=1 ";
                for (int i = 2; i < amount; i++)
                {
                    BigInteger n3 = n1 + n2;
                    result = result + "F" + (i+1) + "=" + n3 + "\n ";
                    n1 = n2;
                    n2 = n3;
                }
            }
        }
    }
}
