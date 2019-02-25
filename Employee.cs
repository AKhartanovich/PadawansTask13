using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PadawansTask13
{
    class Employee
    {
        public string _Surname { get; set; }
        private int _Age { get; }
        public Employee()
        {
            _Surname = string.Empty;
        }
        public Employee(string Surname, int Age)
        {
            _Surname = Surname;
            _Age = Age;
        }
        private string GetAge()
        {
            return _Age.ToString();
        }
        public void ChangeSurname(string newSurname)
        {
            _Surname = newSurname;
        }

        public string GetInfo
        {
            get { return "Surname: {Employee.Surname}, Age: {Employee.Age}"; }
        }
        public string GetEmployeeInfo()
        {
            return "Surname: " + _Surname + ", Age: " + _Age;
        }
    }
}