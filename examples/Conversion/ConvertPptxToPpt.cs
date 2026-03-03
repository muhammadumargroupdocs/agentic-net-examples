using System;

namespace PresentationConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source PPTX file
            string inputFile = "input.pptx";

            // Path for the converted PPT file
            string outputFile = "output.ppt";

            // Load the PPTX presentation
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputFile))
            {
                // Save the presentation in PPT format
                presentation.Save(outputFile, Aspose.Slides.Export.SaveFormat.Ppt);
            }
        }
    }
}