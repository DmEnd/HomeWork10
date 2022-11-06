using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    internal class Angle
    {
        //Поля
        int gradus;
        int min;
        int sec;

        //Cвойства
        public int Gradus
        {
            set
            {

                if( 360< value )
                {
                    gradus = value % 360;
                }
                else if(value < -360)
                {
                    value = value % 360;
                    gradus = value + 360;
                }
                else if(value < 0)
                {
                    gradus = value + 360;
                }
                else
                {
                    gradus = value;
                }
            }
            get
            {
                return gradus;
            }
        }

        public int Min
        {
            set
            {
                if (60 < value)
                {
                    Gradus+= value / 60;
                    min = value % 60;
                }
                else if (value < -60)
                {
                    Gradus += value / 60-1;
                    min = 60+value % 60;  
                }
                else if (value < 0)
                {
                    Gradus--;
                    min = 60 + value % 60;
                }
                else
                {
                    min = value;
                }
            }
            get
            {
                return min;
            }
        }

        public int Sec
        {
            set
            {
                if (60 < value)
                {
                    Min += value / 60;
                    sec = value % 60;
                }
                else if (value < -60)
                {
                    Min += value / 60 - 1;
                    sec = 60 + value % 60;
                }
                else if (value < 0)
                {
                    Min--;
                    min = 60 + value % 60;
                }
                else
                {
                    sec = value;
                }
            }
            get
            {
                return sec;
            }
        }
        //Конструктор
        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        //Метод
        public double ToRadians()
        {
            return ((double)gradus + (double)min / 60 + (double)sec / 60 / 60)/360*Math.PI;
        }

    }
}
