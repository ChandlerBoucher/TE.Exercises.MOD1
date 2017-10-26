﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person()
        {

        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
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
                lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
        
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public bool IsAdult()
        {
            if(age >= 18)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }
}
