using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            var inputPath = "input.pptx";
            var outputPath = "output.pdf";

            using (var presentation = new Aspose.Slides.Presentation(inputPath))
            {
                // Export the presentation with animations to PDF
                presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf);
            }
        }
    }
}