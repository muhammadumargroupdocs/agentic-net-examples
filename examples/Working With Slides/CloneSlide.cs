using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define the directory and file paths
        string dataDir = "C:\\Data\\";
        string inputFile = dataDir + "input.pptx";
        string outputFile = dataDir + "output.pptx";

        // Load the presentation
        using (Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputFile))
        {
            // Get the slide collection
            Aspose.Slides.ISlideCollection slides = pres.Slides;

            // Clone the first slide to the end of the collection
            slides.AddClone(slides[0]);

            // Save the updated presentation
            pres.Save(outputFile, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}