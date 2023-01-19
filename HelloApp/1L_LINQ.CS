// Language INtegrated Query - LINQ
// Way/technique to query collections

using System;
using System.Collections.Generic;
using System.Linq;

class Linq
{
    int[] numbers = { 2, 0, 3, 4, 5, 56, 12, 10, 23, 45, 67, 40 };
    List<string> names = new() { "Bishnu", "Sagar", "Prem", "Kran", "Sajan", "Naresh" };
    List<Employee> employees=new()
    {
        new Employee() {Name ="Ram Basnet", Age=23,Department="HR", Designation="Software Engineer"},
        new Employee() {Name ="Krishna Bhusal", Age=20,Department="R&D", Designation="Dotnet Developer"},
        new Employee() {Name ="Badri Giri", Age=23,Department="HR", Designation="Software Engieer"},
        new Employee() {Name ="Prakesh Raut", Age=20,Department="R&D", Designation="QA"}
    };

    public void Test()
    {
        // Filters
        //1. Get all even numbers in "numbers"
        var evenNums = numbers.Where(num => num % 2 == 0); //method Syntax

        evenNums= from num in numbers       //expression Syntax
                    where num%2==0
                    select num;



        //2. Get all odd numbers in "numbers"
        var oddNums = numbers.Where(num => num % 2 != 0);

        oddNums= from num in numbers
                where(num % 2 != 0)
                select  num;

        //3. Get all numbers which ends with "0"        
        var numsEnding0 = numbers.Where(num => num.ToString().EndsWith("0"));
         numsEnding0= from num in numbers
                        where num.ToString().EndsWith("0")
                        select num;

        // Projections
        //4. Get squares of all numbers in "numbers" array
        var squares = numbers.Select(num => num * num);

        foreach (var n in squares)
        {
            Console.WriteLine(n);
        }

        //5. Get squares of elements which are greater than 50

        //6. Get all person names which starts with letter 'A' in "names" list
        var namesStartingA = names.Where(n => n.StartsWith("a", StringComparison.CurrentCultureIgnoreCase));

        //7. From "names" list, get all person names with less than 4 characters 
        // and convert them to uppercase

    }

 
    public void LINQDay2()
    {
        //Quantifiers: Any, ALL (returns true or false)
        //1. Find if "number" array contain any even number

        var hasEven = numbers.Any(n => n % 2 == 0);

        //2. find if "numbers" array has all even  numbers
        var allEven = numbers.All(n => n % 2 == 0);

        //3. Get first 5 elements from numbers
        var firstFive = numbers.Take(5);

        //3. Get first 5 elements skkiping first two numbers
        var skipTwo = numbers.Skip(2).Take(5);

    }
    public void LearnToQueryComplexCollection()
    {
        //1. Get all Employees in HR Department
        var x=employees.Where(e=>e.Department=="HR");

        //2. Get names of all employees in HR department 
        var x1=employees.Where(e=>e.Department=="HR").Select(e=>e.Name);
         x1= from e in employees
            where e.Department=="HR"
            select e.Name;

        //3. Get all software engineers under AGE of 22

        var y= employees.Where(e=>e.Designation=="Software Engineer" && e.Age<24);
       
        foreach (var e in y)
        {
            Console.WriteLine($"{e.Name}");
        }
        
    }
}


public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }
    public string Designation { get; set; }

}