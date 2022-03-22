using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT_Result_Processing_System
{
    internal class Student
    {
        public string id;
        public string name;
        public string attendance;
        public string quiz1;
        public string quiz2;
        public string quiz3;
        public string quiz4;
        public string quizTotal;
        public string mid;
        public string final;
        public string viva;
        public string total;
        public string percentage;
        public string grade;

        public static int Count { get; internal set; }

        public bool exixtenceCheck(string ID)
        {
            if (id == ID)
            {
                return true;
            }
            else
                return false;
        }

        public string printid()
        {
            return id;
        }
        public string printname()
        {
            return name;
        }
        public string printPercent()
        {
            return percentage;
        }
        public string printGrade()
        {
            return grade;
        }
    }
}
