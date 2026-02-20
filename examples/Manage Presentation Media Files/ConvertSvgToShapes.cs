using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertSvgToShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the SVG file
            string svgFilePath = Path.Combine(Environment.CurrentDirectory, "example.svg");

            // Load SVG data into a byte array
            byte[] svgData = File.ReadAllBytes(svgFilePath);

            // Create an SvgImage object from the SVG data
            Aspose.Slides.SvgImage svgImage = new Aspose.Slides.SvgImage(svgData);

            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Add the SVG as a group of shapes on the first slide
            // Parameters: SVG image, X, Y, Width, Height
            Aspose.Slides.IGroupShape groupShape = presentation.Slides[0].Shapes.AddGroupShape(svgImage, 0f, 0f, 500f, 500f);

            // Save the presentation as PPTX
            string outputPath = Path.Combine(Environment.CurrentDirectory, "SvgConverted.pptx");
            presentation.Save(outputPath, SaveFormat.Pptx);

            // Dispose the presentation
            presentation.Dispose();
        }
    }
}