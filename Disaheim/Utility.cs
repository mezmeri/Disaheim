using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            double result = 0;
            switch (amulet.Quality)
            {
                case Level.low:
                    result = 12.5;
                    break;
                case Level.medium:
                    result = 20.0;
                    break;
                case Level.high:
                    result = 27.5;
                    break;
            } return result;
        }
        public double GetValueOfCourse(Course course)
        {
            int hour = course.DurationInMinutes / 60;
            int remainder = course.DurationInMinutes % 60;
            if (remainder > 0)
            {
                hour++;
            }
            double price = hour * 875;
            return price;
        }

    }
}
