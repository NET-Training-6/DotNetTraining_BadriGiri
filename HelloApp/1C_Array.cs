class ArrayLearner
{
    public void ArraysAssigment()
    {
        string[] names = {"Badri","Ram","Giri","Aran","Shah","Prakesh","Giri","Aran","Shah","Prakesh"};
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"{names[i]}\n");
        }
        var salaries= new double[6];
        Console.WriteLine("Enter Salary:\n");
        for (int s = 0; s < salaries.Length; s++)
        {
            salaries[s]=double.Parse(Console.ReadLine());
        }
        Console.WriteLine("The recorded list of Salary are:\n");
        foreach (var salary in salaries)
        {
            Console.WriteLine(salary);
        }
    }
}