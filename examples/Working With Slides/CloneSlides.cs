using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define file paths
        string dataDir = "Data/";
        string inputFile = dataDir + "input.pptx";
        string outputFile = dataDir + "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputFile);

        // Get the slide collection
        Aspose.Slides.ISlideCollection slides = pres.Slides;

        // Clone first two slides to the end of the presentation
        slides.AddClone(slides[0]);
        slides.AddClone(slides[1]);

        // Save the modified presentation
        pres.Save(outputFile, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        pres.Dispose();
    }
}