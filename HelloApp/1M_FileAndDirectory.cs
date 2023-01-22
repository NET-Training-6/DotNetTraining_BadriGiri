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
            
        //Create 20 folders A, B, C, ... T. In each folder there should be a file with name same as its parent folder and that file should contain current datetime stamp.
    public void CreateFolderWithText()
    {
        var nameFolder=new[] {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T'};
        foreach (var name in nameFolder)
        {
            var folderPath20=@$"E:\Documents\Dotnet Programming\DotNetTraining_BadriGiri\HelloApp\{name}";
            Directory.CreateDirectory(folderPath20);
            var filePath=@$"{folderPath20}\{name}.txt";
            File.WriteAllText(filePath, DateTime.Now.ToString("yyyy dd, MMMM"));
        }
    }
}