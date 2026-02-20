using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Define the folder where the presentation files are located
        string dataDir = "C:\\Presentations\\";
        // Input presentation file name
        string inputFile = "input.pptx";
        // Output presentation file name
        string outputFile = "output.pptx";

        // Load the presentation
        Presentation presentation = new Presentation(dataDir + inputFile);

        // Remove the slide at index 0 (first slide)
        presentation.Slides.RemoveAt(0);

        // Save the modified presentation
        presentation.Save(dataDir + outputFile, SaveFormat.Pptx);

        // Clean up resources
        presentation.Dispose();
    }
}