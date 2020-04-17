
using System;
using System.Collections;
using System.Collections.Generic;

namespace Quiz1
{
    // Stephanie Ludgate

    
    class Program
    {
        // delegate to use in Main method
        public delegate int SalaryCompare(int empSalary, int currentLowest);
        static void Main(string[] args)
        {
            // QUESTION 1 - Multiple Choice - Which statement is correct?
            Console.WriteLine("---- QUESTION 1 ----");
            // A - Properties of anonymous types will be read-only properties so you cannot change their values
            Console.WriteLine("A - Properties of anonymous types will be read-only properties so you cannot change their values");

            // QUESTION 2A - Use generic collection & put 5 employees in it
            Console.WriteLine();
            Console.WriteLine("---- QUESTION 2 ----");
            List<Employee> listEmployee = new List<Employee>();
            listEmployee.Add(new Employee(1, "Steph", 100000));
            listEmployee.Add(new Employee(2, "Devon", 90000));
            listEmployee.Add(new Employee(3, "Josh", 120000));
            listEmployee.Add(new Employee(4, "Trevor", 80000));
            listEmployee.Add(new Employee(5, "Alex", 75000));

            // QUESTION 2B - Iterate through collection & write the name of employee in console
            listEmployee.ForEach(e => Console.WriteLine($"Name: {e.emplName}"));

            // QUESTION 2C - Use delegate to find lowest and highest salary
            SalaryCompare lowestDelegate = Lowest;
            SalaryCompare highestDelegate = Highest;

            // STILL FIGURING THIS OUT :(
            //int lowSalary = GetExtremeSalary(listEmployee, lowestDelegate);
            //int highSalary = GetExtremeSalary(listEmployee, highestDelegate);

            //Console.WriteLine($"Lowest Salary: {lowSalary}");
            //Console.WriteLine($"Highest Salary: {highSalary}");

            // QUESTION 3 - Use Tuple to create an object which has 3 fields (name, age, address) and print the fields
            Console.WriteLine();
            Console.WriteLine("---- QUESTION 3 ----");
            var person = (Name: "Steph", Age: 30, Address: "Montreal");
            Console.WriteLine($"Name: {person.Name} Age: {person.Age} Address: {person.Address}");
            Console.WriteLine("Name: {0} Age: {1} Address: {2}", person.Name, person.Age, person.Address);

            // QUESTION 4 - Use Dictionary to keep the values of information of 5 employees in question 2
            Console.WriteLine();
            Console.WriteLine("---- QUESTION 4 ----");
            // Using sorted list instead of hash table so that it can be sorted by empId
            SortedList sortedEmployees = new SortedList();
            foreach(Employee e in listEmployee)
            {
                sortedEmployees.Add(e.emplId, "Office address");
            }
            foreach(DictionaryEntry element in sortedEmployees)
            {
                Console.WriteLine("key: {0}, value: {1}", element.Key, element.Value);
            }

            // QUESTION 5 - Create Generic class that only accepts class reference
            Console.WriteLine();
            Console.WriteLine("---- QUESTION 5 ----");
            MyGenericClass<Employee>.Print(new Employee(6, "Stephanie", 70000));
            MyGenericClass<string>.Print("Steph");

            // QUESTION 6 - Use extension method to check if number is divisible by 3
            Console.WriteLine();
            Console.WriteLine("---- QUESTION 6 ----");
            int i = 6;
            int j = 8;
            int divisor = 3;
            Console.WriteLine($"Is {i} divisible by {divisor}?  {i.IsDivisibleBy(divisor)}");
            Console.WriteLine($"Is {j} divisible by {divisor}?  {j.IsDivisibleBy(divisor)}");

            // QUESTION 7 - Use predicate to check for vowels in a string
            Console.WriteLine();
            Console.WriteLine("---- QUESTION 7 ----");
           // Char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
           // I don't think I did this correctly, but was only way I could think to in the moment
            Predicate<string> hasVowels = st =>
            {
                List<Char> vowels = new List<char>();
                for (int i = 0; i < st.Length; i++)
                {
                    if (st[i] == 'a')
                    {
                        vowels.Add('a');
                    } else if (st[i] == 'e')
                    {
                        vowels.Add('e');
                    } else if (st[i] == 'i')
                    {
                        vowels.Add('i');
                    } else if (st[i] == 'o')
                    {
                        vowels.Add('o');
                    } else if (st[i] == 'u')
                    {
                        vowels.Add('u');
                    }
                }
                if(vowels.Count == 0)
                {
                    Console.Write($"String '{st}' contains NO vowels");
                    return false;
                } else
                {
                    Console.Write($"String '{st}' contains vowels: ");
                    foreach(char c in vowels)
                    {
                        Console.Write(c + " ");
                    }
                    return true;
                }
                
            };

            bool result = hasVowels("Hello");
            Console.WriteLine();
            bool result2 = hasVowels("Nvhwl");
        }

        public int GetExtremeSalary(List<Employee> lstEmployees, SalaryCompare comparator)
        {
            int salary = 0;

            foreach (Employee e in lstEmployees)
            {
                int employeeSalary = e.emplSalary;
                salary = comparator(employeeSalary, salary);
            }
            return salary;

        }

        public static int Lowest(int empSalary, int currentLowest)
        {
            return Math.Min(empSalary,currentLowest);
        }

        public static int Highest(int empSalary, int currentLowest)
        {
            return Math.Max(empSalary, currentLowest);
        }


    }
}
