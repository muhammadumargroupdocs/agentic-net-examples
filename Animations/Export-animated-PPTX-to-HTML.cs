using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ExportAnimatedPresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source PPTX file
            string inputPath = "input.pptx";

            // Path for the exported HTML file
            string outputPath = "output.html";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Configure HTML5 export options to include animations
            Aspose.Slides.Export.Html5Options htmlOptions = new Aspose.Slides.Export.Html5Options();
            htmlOptions.AnimateShapes = true;
            htmlOptions.AnimateTransitions = true;

            // Export the presentation to HTML with animations
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html5, htmlOptions);

            // Ensure the presentation is saved and resources are released
            presentation.Dispose();
        }
    }
}