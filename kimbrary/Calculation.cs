namespace Kimbrary
{
    namespace Calculation
    {
        public static class Calculation
        {
            public static int GetProgressInPercents(double currentValue, double endValue)
            {
                if (currentValue >= endValue)
                {
                    return 100;
                }
                else
                {
                    double rawPercent = currentValue / endValue * 100;

                    if (rawPercent > 99.0 && rawPercent < 100.0)
                    {
                        return Convert.ToInt32(rawPercent.ToString()[..rawPercent.ToString().IndexOf(',')]);
                    }
                    else
                    {
                        return Convert.ToInt32(rawPercent);
                    }
                }
            }
        }
    }
}