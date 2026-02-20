using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Paths to the source and output presentations
        string sourcePath = "input.pptx";
        string outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(sourcePath);

        // Index of the slide to delete (zero‑based)
        int slideIndex = 1; // example: delete the second slide

        // Delete the slide if the index is valid
        if (slideIndex >= 0 && slideIndex < pres.Slides.Count)
        {
            pres.Slides.RemoveAt(slideIndex);
        }

        // Save the modified presentation
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up
        pres.Dispose();
    }
}