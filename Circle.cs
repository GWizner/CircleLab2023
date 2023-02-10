using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLab2023
{
    public class Circle
    {
        public double rad;
        public double circ;
        public double area;

        public Circle(double radius)
        {
            rad = radius;
        }
        public double CalculateCircumference()
        {
            circ = 2 * Math.PI * rad;
            return circ;
        }
        public string CalculateFormattedCircumference()
        {
            string roundCirc = FormatNumber(CalculateCircumference());
            return "The " + "\x1b[38;5;207m" + "circumference " + "\x1b[0m" + "is " +
                "\x1b[38;5;207m" + $"{roundCirc}" + "\x1b[0m";
        }
        public double CalculateArea()
        {
            area = Math.PI * Math.Pow(rad, 2);
            return area;
        }
        public string CalculateFormattedArea()
        {
            string roundArea = FormatNumber(CalculateArea());
            return "The " + "\x1b[38;5;129m" + "area " + "\x1b[0m" + "is " + "\x1b[38;5;129m" +
                $"{roundArea}" + "\x1b[0m";
        }
        private string FormatNumber(double x)
        {
            string round = Math.Round(x, 2).ToString();
            return round;
        }
    }
}
