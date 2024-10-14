using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GulienkoPO.Sprint2.Task3.V21.Lib
{
    public class DataService : ISprint2Task3V21
    {
        public double Calculate(double x)
        {
            double res = 0;
            if (x > 1)
            {
                res = x * Math.Pow(((x + 9) / (x - 1)), x);
            }
            else if (x == 0)
            {
                res = 10 / 12;
            }
            else if (-25 < x && x < 2)
            {
                Math.Pow(1 + 1 / Math.Pow(x, 2), x);
            }
            else if (x < -25)
            {
                res = x + (10 * x) - (1 / x);
            }
            return Math.Round(res, 3);
        }
    }
}