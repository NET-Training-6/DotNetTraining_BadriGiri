// Think of a real world scenario for following:
// Class 1 should has some fields and methods
// Class 2 inherits Class 1
// Class 3 has some fields on it
// Interface 1 have some method definitions
// Class 2 and Class 3 implements Interface 1


class MajorSubject
{
    public int english;
    public int math;
    public MajorSubject(int E, int M)
    {
        this.english=E;
        this.math=M;

    }
    public void PrintMark()
    {
        var total=english+math;
        Console.WriteLine($"Total marks Obtained in Major Subject: {total}");
    }
}
class OptionalSubject:MajorSubject, IMessage
{
    public int physics;
    public OptionalSubject(int P): base(P,P)
    {
        this.physics=P;

    }

    public void Message()
    {
        int s=english+math+physics;
        Console.WriteLine("Total MarkS Obtained in Engineering Subject: "+s);
    }

}
class Percentage:IMessage
{  
    int p;

    public new void Message()
    {
        Console.WriteLine("Congrulations:");

    }
}
interface IMessage
{
    public void Message();
}

class InheritanceTest
{
    static void Main(string[] args)
    {
        MajorSubject M=new MajorSubject(45,78);
        M.PrintMark();
       OptionalSubject op1=new OptionalSubject(78);
        op1.Message();
        
    }
}