using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Paths for input presentation, output presentation, and external theme file
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";
        string themePath = "theme.thmx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Apply external theme to the first master slide and its dependent slides
        Aspose.Slides.IMasterSlide masterSlide = presentation.Masters[0];
        masterSlide.ApplyExternalThemeToDependingSlides(themePath);

        // Save the modified presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation object
        presentation.Dispose();
    }
}