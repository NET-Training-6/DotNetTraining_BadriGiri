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
        int principle, rate, time;
        Console.WriteLine("Enter the principle:\n");
        principle=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Rate:\n");
        rate=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the time:\n");
        time=Convert.ToInt32(Console.ReadLine());
        int si, ci;
        si=(principle*rate*time)/100;
        Console.WriteLine("simple interest is :"+si);
        ci=principle*((1+rate/100)^time-1);
        Console.WriteLine("Compound interest is : "+ci);

// assigment to check number wheather multiple of 3 and 5

        // int num;
        // Console.WriteLine("Enter your check number:");
        // num=Convert.ToInt32(Console.ReadLine());
        // if (num %3==0 && num%5==0)
        // {
        //     Console.WriteLine(num+" is a multiple of 3 and 5");
        // }
        // else if(num%5==0)
        // {
        //     Console.WriteLine(num+" is multiple of 5");
        // }
        // else if(num%3==0)
        // {
        //     Console.WriteLine(num+" is multiple of 3");
        // }
        // else
        // {
        //     Console.WriteLine(num+" is not multiple of 3 nor 5");
        // }


// Program to calculate BMI 
        int heightF, heightI, weight;
        string name;
        float converIntoMeter, bmi;
        Console.WriteLine("Enter your Name:\n");
        name= Console.ReadLine();
        Console.WriteLine("Enter your weight in KG:");
        weight=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your Height in feet and inche: \n");
        heightF=Convert.ToInt32(Console.ReadLine());
        heightI=Convert.ToInt32(Console.ReadLine());
        converIntoMeter=0.3048f*heightF+0.0254f*heightI;
        bmi=weight/(converIntoMeter*converIntoMeter);
        Console.WriteLine("The BODY MASS INDEX of "+name+" with Height "+heightF+"feet "+ heightI+"inche"+" and WEIGHT "+weight+" KG is: "+bmi);
        if(bmi<18.5)
        {
            Console.WriteLine("\n ***************Under Weight***************");
        }
        else if(bmi>18.5 && bmi<25)
        {
            Console.WriteLine("\n ******************Healthy Weight*****************");
        }
        else if(bmi>25 &&bmi<30)
        {
            Console.WriteLine("\n ****************Over Weight***************");
        }
        else{
            Console.WriteLine("\n **************obesity range***********************");
        }
        


    }
}