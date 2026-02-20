using System;
using System.Collections.Generic;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace DeleteMultipleSlidesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            System.String inputPath = "input.pptx";
            System.String outputPath = "output.pptx";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Indices of slides to delete (0‑based). Example: delete slides 2, 4 and 6.
            System.Int32[] slidesToDelete = new System.Int32[] { 1, 3, 5 };

            // Sort indices in descending order to avoid re‑indexing issues while removing
            System.Array.Sort(slidesToDelete);
            for (System.Int32 i = slidesToDelete.Length - 1; i >= 0; i--)
            {
                System.Int32 index = slidesToDelete[i];
                if (index >= 0 && index < presentation.Slides.Count)
                {
                    presentation.Slides.RemoveAt(index);
                }
            }

            // Save the modified presentation
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Clean up
            presentation.Dispose();
        }
    }
}