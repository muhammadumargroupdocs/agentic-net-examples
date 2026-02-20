using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define input and output paths
            System.String dataDir = "C:\\Data\\";
            System.String inputFile = dataDir + "input.pptx";
            System.String outputFile = dataDir + "output.pptx";

            // Load presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputFile);

            // Iterate through all slides
            for (int index = 0; index < presentation.Slides.Count; index++)
            {
                Aspose.Slides.ISlide slide = presentation.Slides[index];
                // Example operation: write slide number to console
                System.Console.WriteLine("Processing slide " + (index + 1));
            }

            // Save presentation
            presentation.Save(outputFile, Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose presentation
            presentation.Dispose();
        }
    }
}