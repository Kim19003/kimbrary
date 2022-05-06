namespace Kimbrary
{
    namespace Calculation
    {
        public class Calculation
        {
            public static int GetProgressInPercents(double currentValue, double endValue)
            {
                if (currentValue >= endValue)
                {
                    return 100;
                }
                else
                {
                    return Convert.ToInt32((currentValue / endValue) * 100);
                }
            }
        }
    }
}