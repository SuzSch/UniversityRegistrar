using System;
using System.Collections.Generic;
using System.Linq;


namespace UniversityRegistrar.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public DateTime DateOfEnrollment { get; set; }

    }
}