using System;

namespace Open_Lab_02._01
{
    public class Exercise
    {
        public double[] Create5Numbers()
        {
            double[] num = new double[5];
            new random = new random();
            for(int i=0; i < num.Lenght; i++)
            {
                num[i] = random.NextDouble();
            }
            return num;
        }

        public double GetSecond(double[] numbers)
        {
            return numbers[1];
        }
    }
}