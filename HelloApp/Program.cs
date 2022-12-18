internal class Program
{
    private static void Main()
     {
    //     int number;
    //     Console.WriteLine("Enter number");
    //     number= Convert.ToInt16(Console.ReadLine());
        

    //     if (number%2==0)
    //     {
    //         Console.WriteLine(number +" is even");
    //     }
    //     else
    //     {
    //             Console.WriteLine(number+" is odd");
    //     }

        // cw: find simple intere

// simple interest cw:
        // int principle, rate, time;
        // Console.WriteLine("Enter the principle:\n");
        // principle=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter the Rate:\n");
        // rate=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter the time:\n");
        // time=Convert.ToInt32(Console.ReadLine());
        // int si;
        // si=(principle*rate*time)/100;
        // Console.WriteLine("simple interest is :"+si);

// assigment of multiple of 3 and 5

        int num;
        Console.WriteLine("Enter your check number:");
        num=Convert.ToInt32(Console.ReadLine());
        if (num %3==0 && num%5==0)
        {
            Console.WriteLine(num+" is a multiple of 3 and 5");
        }
        else if(num%5==0)
        {
            Console.WriteLine(num+" is multiple of 5");
        }
        else if(num%3==0)
        {
            Console.WriteLine(num+" is multiple of 3");
        }
        else
        {
            Console.WriteLine(num+" is not multiple of 3 nor 5");
        }


    }
}