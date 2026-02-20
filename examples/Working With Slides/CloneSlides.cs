using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";

        // Load the source presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Get the slide collection
        Aspose.Slides.ISlideCollection slides = pres.Slides;

        // Define the range of slides to clone (e.g., slides 0 to 2)
        int startIndex = 0;
        int endIndex = 2; // inclusive

        // Clone each slide in the specified range to the end of the presentation
        for (int i = startIndex; i <= endIndex; i++)
        {
            slides.AddClone(slides[i]);
        }

        // Save the modified presentation
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        pres.Dispose();
    }
}