using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source presentation
            string sourcePath = "input.pptx";

            // Load the presentation
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath))
            {
                // Iterate through each slide
                for (int index = 0; index < presentation.Slides.Count; index++)
                {
                    // Slides are 1‑based for the Save method
                    int[] slideNumber = new int[] { index + 1 };
                    string outputPath = $"slide_{index + 1}.ppt";

                    // Save the single slide as a PPT file
                    presentation.Save(outputPath, slideNumber, Aspose.Slides.Export.SaveFormat.Ppt);
                }

                // Save the original presentation before exiting
                presentation.Save("output.ppt", Aspose.Slides.Export.SaveFormat.Ppt);
            }
        }
    }
}