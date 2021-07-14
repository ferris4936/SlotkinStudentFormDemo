using StudentForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;   

namespace SlotkinStudentFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string major = "TBD";
            if (programmingRadioButton.Checked)
            {
                major = programmingRadioButton.Text;
            }
            else if (webDesignRadioButton.Checked)
            {
                major = webDesignRadioButton.Text;
            }
            else if (ITRadioButton.Checked)
            {
                major = ITRadioButton.Text;
            }

            //Instantiate a student
            Student st = new Student(studentIDTextBox.Text,
                                     textBox1.Text,  
                                     lastNameTextBox.Text,
                                     major);
            st.StudentNumber = studentIDTextBox.Text;

            //Count number of check boxes checked
            int count = 0;
            if (cis101CheckBox.Checked)
            {
                count++;
            }
            if (cis102CheckBox.Checked)
            {
                count++;
            }
            if (cis103CheckBox.Checked)
            {
                count++;
            }
            if (cis104CheckBox.Checked)
            {
                count++;
            }

            string[] courses = new string[count];
            int[] scores = new int[count];

            int index = 0;
            if (cis101CheckBox.Checked)
            {
                courses[index] = cis101CheckBox.Text;
                scores[index++] = Convert.ToInt32(score101TextBox.Text);
            }
            if (cis102CheckBox.Checked)
            {
                courses[index] = cis102CheckBox.Text;
                scores[index++] = Convert.ToInt32(score102TextBox.Text);
            }
            if (cis103CheckBox.Checked)
            {
                courses[index] = cis103CheckBox.Text;
                scores[index++] = Convert.ToInt32(score103TextBox.Text);
            }
            if (cis104CheckBox.Checked)
            {
                courses[index] = cis104CheckBox.Text;
                scores[index++] = Convert.ToInt32(score104TextBox.Text);
            }

            //Set new arrays into student object
            st.Scores = scores;
            st.Courses = courses;

            //display output

            string summary =
                "Student's Major is " + st.Major + "."+
                "\r\nStudent's First Name is " + st.FirstName +"." +
                "\r\nStudent's Last Name is " + st.LastName + "." +
                "\r\nStudent's Average is " + st.Average + "." +
                "\r\nCourses: ";
            foreach (string course in st.Courses)
            {
                summary += "\r\n" + course;            
            }
            summaryTextBox.Text = summary;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "http://www.couorse.com");
            linkLabel1.LinkVisited = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string major = "TBD";
            if (programmingRadioButton.Checked)
            {
                major = programmingRadioButton.Text;
            }
            else if (webDesignRadioButton.Checked)
            {
                major = webDesignRadioButton.Text;
            }
            else if (ITRadioButton.Checked)
            {
                major = ITRadioButton.Text;
            }

            //Instantiate a student
            Student st = new Student(studentIDTextBox.Text,
                                     textBox1.Text,
                                     lastNameTextBox.Text,
                                     major);
            st.StudentNumber = studentIDTextBox.Text;

            //Count number of check boxes checked
            int count = 0;
            if (cis101CheckBox.Checked)
            {
                count++;
            }
            if (cis102CheckBox.Checked)
            {
                count++;
            }
            if (cis103CheckBox.Checked)
            {
                count++;
            }
            if (cis104CheckBox.Checked)
            {
                count++;
            }

            string[] courses = new string[count];
            int[] scores = new int[count];

            int index = 0;
            if (cis101CheckBox.Checked)
            {
                courses[index] = cis101CheckBox.Text;
                scores[index++] = Convert.ToInt32(score101TextBox.Text);
            }
            if (cis102CheckBox.Checked)
            {
                courses[index] = cis102CheckBox.Text;
                scores[index++] = Convert.ToInt32(score102TextBox.Text);
            }
            if (cis103CheckBox.Checked)
            {
                courses[index] = cis103CheckBox.Text;
                scores[index++] = Convert.ToInt32(score103TextBox.Text);
            }
            if (cis104CheckBox.Checked)
            {
                courses[index] = cis104CheckBox.Text;
                scores[index++] = Convert.ToInt32(score104TextBox.Text);
            }

            //Set new arrays into student object
            st.Scores = scores;
            st.Courses = courses;

            //display output

            string summary =
                "Student's Major is " + st.Major + "." +
                "\r\nStudent's First Name is " + st.FirstName + "." +
                "\r\nStudent's Last Name is " + st.LastName + "." +
                "\r\nStudent's Average is " + st.Average + "." +
                "\r\nCourses: ";
            foreach (string course in st.Courses)
            {
                summary += "\r\n" + course;
            }
            summaryTextBox.Text = summary;
        }  
    }
}

