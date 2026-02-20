using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Path to the presentation to open
        string inputPath = "input.pptx";
        // Path where the presentation will be saved
        string outputPath = "output.pptx";

        // Open an existing presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Access the first slide (example of using the opened presentation)
        Aspose.Slides.ISlide firstSlide = pres.Slides[0];

        // Perform any desired operations on the presentation here
        // ...

        // Save the presentation before exiting
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Release resources
        pres.Dispose();
    }
}