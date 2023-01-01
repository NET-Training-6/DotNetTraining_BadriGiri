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

    // // }
    // public int Mean(int[] numbers)
    // {
    //     var average=0;
    //     foreach (var number in numbers)
    //     {
    //         average=(average+number)/numbers.Length;
    //     }
    //     return average;

    // }

    public int MinimumNumber(params int[] numbers)
    {
        var minimum =numbers[0];
        foreach (var item in numbers)
        {
            if (item<minimum)
            {
                minimum=item;
            }
        }
        return minimum;
    }
}