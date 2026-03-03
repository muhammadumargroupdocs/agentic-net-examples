using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertPptxToPpt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PPTX file path
            string inputPath = "input.pptx";
            // Output PPT file path
            string outputPath = "output.ppt";

            // Load the PPTX presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);
            // Save as PPT format
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Ppt);
            // Release resources
            presentation.Dispose();
        }
    }
}