namespace ArrayTest;
class ArrayLearner
{
    public void ArraysAssigment()
    {
        string[] names = {"Badri","Ram","Giri","Aran","Shah","Prakesh","Giri","Aran","Shah","Prakesh"};
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"{names[i]}\n");
        }

        // Program to find maximum Salary from the list of Array:
        var salaries= new double[4];
        Console.WriteLine("Enter Salary:\n");
        for (int s = 0; s < salaries.Length; s++)
        {
            salaries[s]=double.Parse(Console.ReadLine());
        }
        double maxSalary=0;
        // Console.WriteLine("The recorded list of Salary are:\n");
        foreach (var salary in salaries)
        {
           if(salary>maxSalary)
           {
                maxSalary=salary;
           }
        }
        Console.WriteLine("The Maximum Salary is: \n"+maxSalary);
    }
}