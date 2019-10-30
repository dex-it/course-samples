using System;
using System.Collections;
using NUnit.Framework;

namespace Stage1.Exercises
{
    [TestFixture]
    public class Exercise2_IEnumerable
    {
        [Test]
        public void IEnumerableIEnumeratorTest()
        {
            var employees = new[]
            {
                new Employee("Ivan", "Ivanov", 213486, 2010),
                new Employee("Petr", "Petrov", 213865, 2015),
                new Employee("Andrei", "Andreev", 213687, 2009),
                new Employee("Vasiliy", "Vasiliev", 213699, 2017),
            };

            var department = new Department(employees);

            foreach (var item in department)
            {
                Console.WriteLine($"{item.EmployeeNumber}: {item.Name} {item.LastName}, {item.HireYear}");
            }

            Console.WriteLine("\n");

            var departmentEnumerator = new DepartmentEnumerator(employees);

            while (departmentEnumerator.MoveNext())
            {
                var emp = departmentEnumerator.Current as Employee;

                Console.WriteLine($"{emp.Name} {emp.LastName}, employee number: {emp.EmployeeNumber}, year: {emp.HireYear}");
            }
        }
    }
    
    public class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int EmployeeNumber { get; set; }
        public int HireYear { get; set; }

        public Employee(string name, string lastName, int employeeNumber, int hireYear)
        {
            Name = name;
            LastName = lastName;
            EmployeeNumber = employeeNumber;
            HireYear = hireYear;
        }
    }
    
    public class Department: IEnumerable
    {
        private readonly Employee[] _employees;

        public Department(Employee[] empArray)
        {
            _employees = new Employee[empArray.Length];

            for (var i = 0; i < empArray.Length; i++)
            {
                _employees[i] = empArray[i];
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public DepartmentEnumerator GetEnumerator()
        {
            return new DepartmentEnumerator(_employees);
        }
    }
    
    public class DepartmentEnumerator: IEnumerator
    {
        private readonly Employee[] _employees;
        private int _position = -1;

        object IEnumerator.Current => Current;
        public Employee Current => _employees[_position];

        public DepartmentEnumerator(Employee[] emp)
        {
            _employees = emp;
        }

        public bool MoveNext()
        {
            if (_position < _employees.Length - 1)
            {
                _position++;
                return true;
            }

            Reset();
            return false;
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
