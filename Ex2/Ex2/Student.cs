using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    //creating the class Student
    class Student
    {
        private double marks;

        //creating the field variable
        public Student (double m)
        {
            marks = m;
        }
        //creating the method
        public string getLetterGrades()
        {
            string letterGrade;
            
            if (marks > 0 && marks <= 60)//if statement converting the entries to string type
            {
                letterGrade = "F";
            }
            else if (marks > 60 && marks <= 100)
            {
                letterGrade = "P";
            }
            else
            {
                letterGrade = "NA";
            }
            return letterGrade;
        }
    }
}
