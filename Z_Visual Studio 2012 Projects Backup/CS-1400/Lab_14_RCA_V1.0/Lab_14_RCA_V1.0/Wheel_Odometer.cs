using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14_RCA_V1._0
{
    class Wheel_Odometer
    {
        const double ONE_MILE = 63360;
        double diameter;
        double circumference;
        double revolutions;

        // default constructor
        public Wheel_Odometer()
        {
        double diameter = 0;
        double circumference = 0;
        double revolutions = 0;
        }

        public double GetDiameter()
        {
            return diameter;
        }

        public void SetDiameter(double p1)
        {
            diameter = p1;
        }

        public double CalcCircumference()
        {
            circumference = Math.PI * diameter;
        }

        public double CalcRevolutions()
        {
            revolutions = ONE_MILE / circumference;
        }

        public void Reset()
        {
            diameter = 0;
            circumference = 0;
            revolutions = 0;
        }
    }
}
