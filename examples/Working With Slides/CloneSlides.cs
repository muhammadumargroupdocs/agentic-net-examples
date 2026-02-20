using System;

class Program
{
    static void Main()
    {
        // Path to the folder containing the presentation
        string dataDir = "C:\\Data\\";
        // Input presentation file
        string inputFile = dataDir + "input.pptx";
        // Output presentation file
        string outputFile = "cloned.pptx";

        // Load the existing presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputFile);
        // Get the slide collection
        Aspose.Slides.ISlideCollection slides = pres.Slides;
        // Clone the first slide and add it to the end of the collection
        slides.AddClone(slides[0]);
        // Save the modified presentation
        pres.Save(dataDir + outputFile, Aspose.Slides.Export.SaveFormat.Pptx);
        // Clean up resources
        pres.Dispose();
    }
}