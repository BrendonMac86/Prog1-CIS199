using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/* Brendon McNamara, CIS-199-01, Group 11
 * 
 * An application that calculates letter grades as P for Pass and F for Fail based on the marks obtained.
 * It also finds the number of instances with the given grades.
 */
namespace Ex1
{
    public partial class LetterGrade : Form
    {
        
        public LetterGrade()
        {
            InitializeComponent();
        }

        //declaring the letterGrades List.
        public List <string> letterGrades = new List<string>();

        //The submit button will take and store the values entered into the first textbox
        private void submitButton_Click(object sender, EventArgs e)
        {
            double marks = double.Parse(marksTextbox.Text);

            //if statement that converts the score from "int" to "string"
            if (0 < marks && marks <= 60)
            {
                letterGrades.Add("F");
            }
            else if (60 < marks && marks <= 100)
            {
                letterGrades.Add("P");
            }
            else
            {
                MessageBox.Show("Not a valid marks."); //Message Box that will show if an erroneous entry is made
            }
            marksTextbox.Clear(); //Clearing the textbox
   
        }

        //Calculate button that retrieves the number of requested instances 
        private void calculateButton_Click(object sender, EventArgs e)
        {
            string grade = letterGradeTextbox.Text.ToUpper(); //converting the input of the second textbox to Upper case 
            int noOfGrades = 0;  //declaring the counter
            for (int i = 0; i < letterGrades.Count; i++)
            {
                if (letterGrades[i] == grade) //if statement that determines what to look for
                {
                    noOfGrades++; //increase the counter by an increment of one
                }
            }
            //Mesage Box that shows the outcome
            MessageBox.Show("Number of instances with given letter grade is:"+noOfGrades);

            //Clearing the second text box
            letterGradeTextbox.Clear();
        
        }
    }
}
