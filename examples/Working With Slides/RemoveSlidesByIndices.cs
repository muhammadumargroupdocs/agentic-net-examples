using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the folder containing the presentation
        string dataDir = "C:\\Data\\";
        // Input and output file names
        string inputFile = dataDir + "input.pptx";
        string outputFile = dataDir + "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputFile);

        // Indices of slides to remove (example values)
        int[] slideIndices = new int[] { 2, 4, 5 };

        // Sort indices in descending order to avoid index shift after removal
        Array.Sort(slideIndices);
        Array.Reverse(slideIndices);

        // Remove each specified slide
        foreach (int index in slideIndices)
        {
            if (index >= 0 && index < presentation.Slides.Count)
            {
                presentation.Slides.RemoveAt(index);
            }
        }

        // Save the modified presentation
        presentation.Save(outputFile, Aspose.Slides.Export.SaveFormat.Pptx);
        // Dispose the presentation object
        presentation.Dispose();
    }
}