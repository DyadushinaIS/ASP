namespace Converter.Components.Pages
{
    public partial class Calculate
    {
        int your_number = 0;
        int your_number_1 = 0;
        string your_number_2 = "";
        string your_number_3 = "";

        string result = "";
        string result_1 = "";
        string result_2 = "";
        string result_3 = "";

        void Convertion()
        {
            result = Convert.ToString(your_number, 2);
        }

        void Convertion_1()
        {
            result_1 = Convert.ToString(your_number_1, 16);
        }
        void Convertion_2()
        {
            int a = 0;
            a = Convert.ToInt32(your_number_2, 2);
            result_2 = Convert.ToString(a, 10);
        }
        void Convertion_3()
        {
            int a = 0;
            a = Convert.ToInt32(your_number_3, 16);
            result_3 = Convert.ToString(a, 10);
        }
    }
}
