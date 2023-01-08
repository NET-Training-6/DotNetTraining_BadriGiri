// //write a class for rectangle, this class should have methods to calculate area and perimeter:

// class rectangle:Ishape
// {
//     double Length;
//     double width;
//     public rectangle(double l, double w)
//     {
//         Length=l;
//         width=w;
//     }
//     public double GetArea()=>Length*width;
//     public double GetPerimeter()=>2*(Length+width);
//      public virtual void PrintDetails()
//     {
//         Console.WriteLine($"The area of triangle having length {Length} and Width {width} is: ");
//     }
// }
// class Square:rectangle, Ishape
// {
//     double side;
//     public Square(double s):base(s,s)
//     {
//         side=s;

//     }
//     public override void PrintDetails()
//     {
//         Console.WriteLine($"The area of square having length {side}: ");
//     }
// }

// class Triangle:Ishape
// {
//     double a,b,c;
//     public Triangle(double a,double b,double c)
//     {
//         this.a=a;
//         this.b=b;
//         this.c=c;
//     }
//     public double GetPerimeter()=>a+b+c;
//     public double GetArea()
//     {
//         var s=a+b+c;
//         var area=Math.Sqrt(s*(s-a)*(s-b)*(s-c));
//         return area;
//     }
//     public void PrintDetails()
//     {
//         Console.WriteLine($"The area of triangle having length {a, b ,c} is: ");
//     }
// }

// interface Ishape
// {

//     public void PrintDetails()
//     {

//     }
// }
// class InheritanceDemo
// {
//     static void Main(string[] args)
//     {
//         var r=new rectangle(45.1,98.5);
//         r.GetArea();
//         r.GetPerimeter();
    
//         var s1=new Square(24.3);
//         s1.GetArea();
//         s1.GetPerimeter();


//     }
// }

