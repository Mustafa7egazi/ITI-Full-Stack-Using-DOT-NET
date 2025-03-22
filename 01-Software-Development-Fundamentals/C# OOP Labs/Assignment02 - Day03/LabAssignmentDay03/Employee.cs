using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignmentDay03
{
    public class Employee
    {
        private int id;
        private string name;
        private int age;
        private int salary;

        public void SetId(int _id)
        {
            id = _id;
        }

        public void SetName(string _name)
        {
            name = _name;
        }

        public void SetAge(int _age)
        {
            age = _age;
        }

        public void SetSalary(int _salary)
        {
            salary = _salary;
        }

        public string Print()
        {
            return $"[ID] {id}:[Name] {name}:[Age] {age}:[Salary] {salary}$";
        }
    }
}
