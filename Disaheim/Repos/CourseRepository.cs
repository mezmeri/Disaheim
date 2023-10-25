using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim.Repos
{
    public class CourseRepository
    {
        private Utility utility = new();
        private List<Course> courses = new();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course? GetCourse(string name)
        {
            return courses.First(c => c.Name == name);
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            foreach (var course in courses)
            {
                totalValue += utility.GetValueOfCourse(course);
            }
            return totalValue;
        }
    }
}
