class ConditionalLearner
{
   public void IncPattern()
   {
        for (int i = 0; i <10; i++)
        {
            for (int j = 1; j < i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
         Console.WriteLine();
   }
   public void DecPattern()
   {
        for (int i = 7; i>0 ; i--)
        {
            for (int j = 0; i>j; j++)
            {
                Console.Write(i);
            }
             Console.WriteLine();
        }
         Console.WriteLine();
   }
   public void HashPattern()
   {
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("#");
                
            }
            Console.WriteLine();
        }
   }

}