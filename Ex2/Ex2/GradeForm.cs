using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Brendon McNamara, CIS-199-01, Group 11
// An application which creates a list of objects

namespace Ex2
{
    public partial class GradeForm : Form
    {   
        //Creating and initializing the list
        private List<Student> studentList = new List<Student>();
        
        public GradeForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Creating the object of type Student
            Student st = new Student(double.Parse(marksTextbox.Text));
            
            //message box showing the result
            MessageBox.Show("This student has letter grade "+st.getLetterGrades());
            
            //adding the object to the list
            studentList.Add(st);

            //clearing the textbox
            marksTextbox.Clear();
        }
    }
}
