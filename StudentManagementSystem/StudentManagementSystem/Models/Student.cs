using System;
using System.Collections.Generic;
using System.Text;
using FakeData;

namespace StudentManagementSystem.Models
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        public string Department { get; set; }
        public double Average { get; set; }
    }
}
