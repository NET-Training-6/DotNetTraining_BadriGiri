class paragraph
{
    string story=@"A Boy was given permission to put his hand into a, \\
        pitcher to get some filberts. But he took such a great fistful \\
        that he could not draw his hand out again. There he stood, unwilling \\
        to give up a single filbert and yet unable to get them all out at once. \\
        Vexed and disappointed he began to cry.";
    public void countSentences()
    {
        var separators=new char[]{'.','?'};
        var sentences=story.Split(separators);

        var noOfSentences=sentences.Length;
        Console.WriteLine($"Sentence Count:{noOfSentences}");
        foreach (var s in sentences)
        {
            Console.WriteLine(s);
            Console.WriteLine("===========================");
            
        }

        var sentence1=sentences[0];
        Console.WriteLine(sentence1);
    }
    public void countWords()
    {
        var separators=new char[]{' ','\t',','};
        string[] words=story.Split(separators,StringSplitOptions.RemoveEmptyEntries);
        int noOfWords=words.Length;
        Console.WriteLine($"Word counts:{noOfWords} and words are following:");
        foreach(var w in words)
        {
            var sabda=w;
            Console.WriteLine("=========================");
            if(sabda.Contains(','))
            {
                sabda=sabda.Replace(",","");
            }
            Console.WriteLine(sabda);

        }
    }
    public void GetFrequciesOfCharacters()
    {
        int[] freq = new int[story.Length];  
        int i, j;  
          
        //Converts given string into character array  
        char[] string1 = story.ToCharArray();  
          
        for(i = 0; i <story.Length; i++) 
        {  
            freq[i] = 1;  
            for(j = i+1; j <story.Length; j++) 
            {  
                if(string1[i] == string1[j]) 
                {  
                    freq[i]++;  
                      
                    //Set string1[j] to 0 to avoid printing visited character  
                    string1[j] = '0';  
                }  
            }  
        }  
          
        //Displays the each character and their corresponding frequency  
        Console.WriteLine("Characters and their corresponding frequencies");  
        for(i = 0; i < freq.Length; i++) 
        {  
            if(string1[i] != ' ' && string1[i] != '0')  
                Console.WriteLine(string1[i] + "-" + freq[i]);  
        }  
    }
}
