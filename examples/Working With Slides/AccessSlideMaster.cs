using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Define input and output file paths
        System.String dataDir = "Data";
        System.String inputPath = System.IO.Path.Combine(dataDir, "input.pptx");
        System.String outputPath = System.IO.Path.Combine(dataDir, "output.pptx");

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Access the first master slide in the presentation
        Aspose.Slides.IMasterSlide masterSlide = presentation.Masters[0];

        // Example operation: rename the master slide
        masterSlide.Name = "RenamedMaster";

        // Save the modified presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}