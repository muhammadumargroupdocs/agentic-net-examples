using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Define directories and file names
        string dataDir = "Data";
        string inputFile = Path.Combine(dataDir, "source.pptx");
        string importFile = Path.Combine(dataDir, "import.pptx");
        string outputFile = Path.Combine(dataDir, "result.pptx");

        // Ensure the data directory exists
        if (!Directory.Exists(dataDir))
        {
            Directory.CreateDirectory(dataDir);
        }

        // Load the main presentation
        Aspose.Slides.Presentation mainPresentation = new Aspose.Slides.Presentation(inputFile);

        // Load the presentation to be imported
        Aspose.Slides.Presentation importPresentation = new Aspose.Slides.Presentation(importFile);

        // Import all slides from the importPresentation into the mainPresentation
        Aspose.Slides.ISlideCollection mainSlides = mainPresentation.Slides;
        Aspose.Slides.ISlideCollection importSlides = importPresentation.Slides;
        for (int i = 0; i < importSlides.Count; i++)
        {
            Aspose.Slides.ISlide slideToClone = importSlides[i];
            mainSlides.AddClone(slideToClone);
        }

        // Save the combined presentation
        mainPresentation.Save(outputFile, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose presentations
        importPresentation.Dispose();
        mainPresentation.Dispose();
    }
}