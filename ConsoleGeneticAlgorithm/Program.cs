using System;
using System.Collections.Generic;

namespace ConsoleGeneticAlgorithm
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double CalculateFunction(List<double> components)
            {
                var score = 0d;
                for (var i = 0; i < components.Count; i++)
                {
                    score -= components[i] * Math.Sin(Math.Sqrt(Math.Abs(components[i])));
                }

                /*var sum = 1d;
                var r = 1d;
                for (var i = 0; i < components.Count; i++)
                {
                    sum += Math.Pow(components[i], 2) / 4000;
                    r *= Math.Cos(components[i] / Math.Sqrt(i + 1));
                }

                score = sum - r;*/
                return score;
            }
            
            var genetic = new Genetic(2000, 0.5, 30, 0.5,
                5000, -500, 500, 10, CalculateFunction);
            genetic.StartGenetic();
            var message = $"Найденное значение: ";
            for (var i = 0; i < genetic.CoordinatesOfMinimum.Count; i++)
            {
                message += $"X{i} = {genetic.CoordinatesOfMinimum[i]} ";
            }

            message += $"min = {genetic.Minimum}";
            Console.WriteLine(message);
            Console.WriteLine("Debug");
            Console.ReadKey();
        }
    }
}