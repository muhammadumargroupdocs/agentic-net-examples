using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Set the data directory
        string dataDir = Path.Combine(Environment.CurrentDirectory, "Data");
        if (!Directory.Exists(dataDir))
            Directory.CreateDirectory(dataDir);

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Get the slide collection
        Aspose.Slides.ISlideCollection slides = pres.Slides;

        // Clone the first slide to the end of the collection
        slides.AddClone(slides[0]);

        // Save the presentation
        string outputFile = Path.Combine(dataDir, "ClonedSlide.pptx");
        pres.Save(outputFile, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up
        pres.Dispose();
    }
}