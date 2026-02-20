using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AddSvgToPresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define input SVG file path
            string svgFilePath = Path.Combine(Environment.CurrentDirectory, "sample.svg");

            // Define output PPTX file path
            string outputPptxPath = Path.Combine(Environment.CurrentDirectory, "output.pptx");

            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Load SVG image from file
            Aspose.Slides.SvgImage svgImage = new Aspose.Slides.SvgImage(svgFilePath);

            // Add SVG image to the presentation's image collection
            Aspose.Slides.IPPImage addedImage = presentation.Images.AddImage(svgImage);

            // Get the first slide (created by default)
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Add the SVG image to the slide as a picture frame
            slide.Shapes.AddPictureFrame(
                Aspose.Slides.ShapeType.Rectangle,
                50,    // X position
                50,    // Y position
                400,   // Width
                300,   // Height
                addedImage);

            // Save the presentation in PPTX format
            presentation.Save(outputPptxPath, SaveFormat.Pptx);

            // Clean up resources
            presentation.Dispose();
        }
    }
}