using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace RemoveVbaMacrosExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            string inputPath = "input.pptx";
            string outputPath = "output.pptx";

            // Load the presentation
            Presentation presentation = new Presentation(inputPath);

            // Remove the first VBA module if any exist
            if (presentation.VbaProject != null && presentation.VbaProject.Modules.Count > 0)
            {
                presentation.VbaProject.Modules.Remove(presentation.VbaProject.Modules[0]);
            }

            // Save the modified presentation
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Release resources
            presentation.Dispose();
        }
    }
}