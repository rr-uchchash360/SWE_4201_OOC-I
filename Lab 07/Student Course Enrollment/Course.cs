using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Enrollment
{
    internal class Course
    {
        private string name;
        public string Name { get { return name; } }

        private string level;
        public string Level { get { return level; } }

        private double courseFee;
        public double CourseFee { get { return courseFee; } }

        static public List<Course> CourseList = new List<Course>();

        public Course(string name, string level, double fees)
        {
            this.name = name;
            this.level = level;
            this.courseFee = fees;
        }
        public bool checkIfCourseExist(string courseName)
        {
            if (courseName == name)
            {
                return true;
            }
            else return false;
        }
    }
}
