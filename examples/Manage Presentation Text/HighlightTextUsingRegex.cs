using System;
using System.Text.RegularExpressions;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace HighlightTextWithRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define input and output file paths
            System.String inputPath = "input.pptx";
            System.String outputPath = "output.pptx";

            // Load the presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

            // Get the first shape on the first slide as an AutoShape
            Aspose.Slides.AutoShape shape = pres.Slides[0].Shapes[0] as Aspose.Slides.AutoShape;

            // Highlight text matching the regular expression
            if (shape != null && shape.TextFrame != null)
            {
                shape.TextFrame.HighlightRegex(
                    new System.Text.RegularExpressions.Regex(@"your_regex_pattern"),
                    System.Drawing.Color.Blue,
                    null);
            }

            // Save the modified presentation
            pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
            pres.Dispose();
        }
    }
}