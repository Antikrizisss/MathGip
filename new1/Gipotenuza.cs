using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new1
{
    class Gipotenuza
    {
        /*
        double katet1;
        double katet2;

        public double Katet1
        {
            get => katet1;
            set
            {
                if (value <= 0)
                {
                    return;
                }
                else
                {
                    katet1 = value;
                }
            }
        }

        public double Katet2
        {
            get => katet2;
            set
            {
                if (value <= 0)
                {
                    return;
                }
                else
                {
                    katet2 = value;
                }
            }
        }

        */
        public double VichislimGipotenuzu(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }

    }
}
