/*
 Soham Patel
November 30, 2023
Assignment 5
Making an application to store and retrive data of student to college while registering for course
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Campus
    {
        public int HSGradeReq { get; set; }
        public int AdmissionTSReq { get; set; }
        public int RegFees { get; set; }
        public List<Program> ListPrograms { get; set; }
    }
}
