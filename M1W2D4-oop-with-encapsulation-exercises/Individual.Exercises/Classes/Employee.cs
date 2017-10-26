using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Employee
    {

        private int employeeId;
        private string firstName;
        private string lastName;
        private double salary;
        private string department;

        public Employee(int employeeId, string firstName, string lastName, double salary)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }

        public int EmployeeId
        {
            get
            {
                return employeeId;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }
        
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                LastName = value;
            }
        }
        public string FullName
        {
            get
            {
                return $"{lastName}, {firstName}";
            }
        }

        public double AnnualSalary
        {
            get
            {
                return salary;
            }
        }

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        public void RaiseSalary(double percent)
        {
            double salChange;
            salChange = (salary * percent) / 100;
            salary = salary + salChange;
        }

    }

}
