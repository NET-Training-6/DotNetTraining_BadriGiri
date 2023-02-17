using Microsoft.AspNetCore.Mvc;

namespace WorkForceManagement.web.Helpers;

public class ProfileImageHelper
{
    public static string SaveImage(IFormFile ProfileImage)
    {
        //save profile image to some location
        var fileName = ProfileImage.FileName;
        var uniqueFileName=$"{Guid.NewGuid()}_{fileName}"; //38bf3eaa-39d3-4ead-aeeb_person.png
        var relativePath = $"/images/profiles/{uniqueFileName}";
        var currerntAppPath=Directory.GetCurrentDirectory();
        var fullFilePath=Path.Combine(currerntAppPath, $"wwwroot/{relativePath}");

        var stream=File.Create(fullFilePath);   
        ProfileImage.CopyTo(stream);

        //return relative path to save to db
        return relativePath;

    }
}
