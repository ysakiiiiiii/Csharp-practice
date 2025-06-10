namespace WeatherSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of Days to Simulate : ");
            int days = int.Parse(Console.ReadLine());

            int[] temperatures = new int[days];

            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };

            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++) {
                temperatures[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            double average = CalculateAverage(temperatures);

            Console.WriteLine($"The max temperature was {MaxTemp(temperatures)}");
            Console.WriteLine($"The min temperature was {temperatures.Min()}");
            Console.WriteLine($"The most common weather condition is [ {MostCommonCondition(weatherConditions)} ]");
            Console.WriteLine($"Average Temperature : {average}");
        }

        static string MostCommonCondition(string[] weatherConditions)
        {
            int count = 0;
            string mostCommon = weatherConditions[0];

            for(int i = 0; i < weatherConditions.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < weatherConditions.Length; j++)
                {
                    if (weatherConditions[i] == weatherConditions[j]){
                        tempCount++;
                    }
                }

                if (tempCount > count)
                {
                    count = tempCount;
                    mostCommon = weatherConditions[i];
                }

            }
            return mostCommon;
        }
        static double CalculateAverage(int[] temperature)
        {
            double sum = 0;

            foreach (int temp in temperature)
            {
                sum += temp;
            }

            double average = sum / temperature.Length;  

            return average;
        }

        static int MaxTemp(int[] temperature)
        {
            int max = temperature[0];

            foreach(int temp in temperature)
            {
                if(temp > max)
                {
                    max = temp;
                }
            }

            return max;
        }
    }

}
