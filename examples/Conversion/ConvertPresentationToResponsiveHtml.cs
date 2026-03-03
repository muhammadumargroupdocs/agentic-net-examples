using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PowerPoint file
        string sourcePath = "input.pptx";
        // Path to the output HTML file
        string outputPath = "output.html";

        // Load the presentation from the file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath);

        // Configure HTML5 export options for responsive layout
        Aspose.Slides.Export.Html5Options htmlOptions = new Aspose.Slides.Export.Html5Options();
        htmlOptions.SlidesLayoutOptions = new Aspose.Slides.Export.HandoutLayoutingOptions
        {
            Handout = Aspose.Slides.Export.HandoutType.Handouts4Horizontal
        };

        // Save the presentation as responsive HTML5
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html5, htmlOptions);
    }
}