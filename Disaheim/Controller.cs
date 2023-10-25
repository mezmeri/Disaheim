using Disaheim.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        private BookRepository bookRepository = new BookRepository();
        private AmuletRepository amuletRepository = new AmuletRepository();
        private CourseRepository courseRepository = new CourseRepository();

        public List<Book> Books { get; set; }
        public List<Amulet> Amulets { get; set; }
        public List<Course> Courses { get; set; }

        public Controller()
        {
            Books = new();
            Amulets = new();
            Courses = new();
        }

        public void AddToList(Book book) 
        { 
            bookRepository.AddBook(book);
        }
        public void AddToList(Amulet amulet) 
        { 
            amuletRepository.AddAmulet(amulet);
        }
        public void AddToList(Course course)
        {
            courseRepository.AddCourse(course);
        }
    }
}
