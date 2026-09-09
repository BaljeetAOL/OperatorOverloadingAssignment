using System;

namespace OperatorOverloadingAssignment
{
    // This class stores employee information
    public class Employee
    {
        // Employee ID number
        public int Id { get; set; }

        // Employee first name
        public string FName { get; set; } = "";

        // Employee last name
        public string LName { get; set; } = "";

        // Compare employees using ID
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (ReferenceEquals(emp1, emp2))
            {
                return true;
            }

            if (emp1 is null || emp2 is null)
            {
                return false;
            }

            return emp1.Id == emp2.Id;
        }

        // Opposite of ==
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Check if two Employee objects are equal
        public override bool Equals(object? obj)
        {
            if (obj is Employee employee)
            {
                return Id == employee.Id;
            }

            return false;
        }

        // Create a hash code using the ID
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}