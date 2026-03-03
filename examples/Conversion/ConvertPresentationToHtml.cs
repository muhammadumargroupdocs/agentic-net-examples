using System;
using Aspose.Slides;
using Aspose.Slides.Export;

public class Program
{
    public static void Main(string[] args)
    {
        // Path to the source PPT/PPTX file
        string inputPath = "input.pptx";
        // Path where the HTML output will be saved
        string outputPath = "output.html";

        // Load the presentation from the file
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Convert and save the presentation to HTML format
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html);
        }
        // Presentation is disposed automatically after the using block
    }
}