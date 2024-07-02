/*
 Soham Patel
November 30, 2023
Assignment 5
Making an application to store and retrive data of student to college while registering for course
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class AboutDCRegistationApp : Form
    {
        public AboutDCRegistationApp()
        {
            InitializeComponent();
            DisplayAppDescription();
        }

        private void DisplayAppDescription()
        {
           StringBuilder appDescription = new StringBuilder();

            // Append the application description with new lines for each of the details.
            appDescription.AppendLine("Welcome to the DC Registration App!");
            appDescription.AppendLine("This application allows you to register students, manage records, and more.");
            appDescription.AppendLine("It provides an easy-to-use interface for handling student information and programs.");

            richTextBox1.Text = appDescription.ToString();
        }

        private void aboutDCAppButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}