using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    internal class Angle
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            get { return gradus; }
            set 
            { 
                gradus = value % 360;
                if (gradus < 0) gradus += 360;
            }
        }

        public  int Min
        {
            get { return min; }
            set
            {
                Gradus += value / 60;
                min = value % 60;
            }
        }

        public int Sec
        {
            get { return sec; }
            set
            {
                Min += value / 60;
                sec = value % 60;
            }
        }

        public Angle(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }

        public double ToRadians()
        {
            return (((double)gradus) + ((double)min) / 60 + ((double)sec) / 3600)  * Math.PI / 180;
        }
    }
}
