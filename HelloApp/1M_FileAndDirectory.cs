using System.IO;
class FileAndDirectory
{
    public void LearnFiles()
    {
        //Create the text file containing Hello world

        var folderPath = @"E:\Documents\Dotnet Programming\DotNetTraining_BadriGiri\HelloApp\TextFile";
        var filePath = @$"{folderPath}\test.txt";
        File.WriteAllText(filePath, "Hello World");

        var folder = @$"{folderPath}\test";
        Directory.CreateDirectory(folder);



    }
    //create a folder with name "A" somewhere and create a text file a.file inside A:

    public void CreateFolder()
    {
        var path = @"E:\Documents\Dotnet Programming\DotNetTraining_BadriGiri\HelloApp\A";
        Directory.CreateDirectory(path);
        var file = @$"{path}\a.file";
        File.WriteAllText(file, "");
        File.WriteAllText(file, DateTime.Now.ToString("yyyy dd, MMMM"));


        //create 10 folder with name folder 1,folder2,folder3...folder 10

        for (int i = 0; i < 10; i++)
        {
            var folderPath10 = @$"E:\Documents\Dotnet Programming\DotNetTraining_BadriGiri\HelloApp\folder {i}";
            Directory.CreateDirectory(folderPath10);
        }
        //create 20 folder A,B,C,D.... T


    }
}