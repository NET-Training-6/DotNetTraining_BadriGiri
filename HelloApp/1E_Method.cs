class MethodLearner
{
    // public bool NumChecker(int x)
    // {
    //     if (x%2==0)
    //     {
    //         return true;
    //     }
    //     else
    //     {
    //         return false;
    //     }

    // }
    public int Mean(int[] numbers)
    {
        var average=0;
        foreach (var number in numbers)
        {
            average=(average+number)/numbers.Length;
        }
        return average;

    }
}