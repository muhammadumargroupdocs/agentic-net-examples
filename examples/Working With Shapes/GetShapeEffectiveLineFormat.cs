using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesExample
{
    class Program
    {
        static void Main()
        {
            // Path to the input presentation
            string inputPath = "input.pptx";

            // Load the presentation
            Presentation pres = new Presentation(inputPath);

            // Get the first shape on the first slide
            IShape shape = pres.Slides[0].Shapes[0];

            // Retrieve the effective line format of the shape
            ILineFormatEffectiveData effectiveLine = shape.LineFormat.GetEffective();

            // Output some effective line properties
            Console.WriteLine("Effective line width: " + effectiveLine.Width);
            Console.WriteLine("Effective line style: " + effectiveLine.Style);
            Console.WriteLine("Effective line dash style: " + effectiveLine.DashStyle);

            // Save the presentation before exiting
            string outputPath = "output.pptx";
            pres.Save(outputPath, SaveFormat.Pptx);

            // Dispose the presentation object
            pres.Dispose();
        }
    }
}