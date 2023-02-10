using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using System.Reflection;

namespace CircleLab2023
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Circle> totCircles = new List<Circle>();
            bool keepAsk = true;

            Console.WriteLine("Welcome to \"Circle Builder.\"\n");
            while (keepAsk)
            {
                double userRad = Validator.getUserRad();

                Circle newCircle = new Circle(userRad);

                string trueCirc = newCircle.CalculateFormattedCircumference();
                string trueArea = newCircle.CalculateFormattedArea();

                Console.WriteLine();
                Console.WriteLine(trueCirc);
                Console.WriteLine();
                Console.WriteLine(trueArea);

                totCircles.Add(newCircle);

                keepAsk = Validator.getContinue();
                Console.WriteLine();
            }

            Console.WriteLine($"You have built " + "\x1b[38;5;196m" + $"{totCircles.Count} " +
                "\x1b[38;5;200m" + "circle(s). " + "\x1b[0m" + "Goodbye.");

        }
    }
}