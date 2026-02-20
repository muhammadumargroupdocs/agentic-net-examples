using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace SvgImageInsertionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the directory containing the SVG file and where the output PPTX will be saved
            string dataDir = @"C:\Data";

            // Build full paths for the input SVG and output PPTX files
            string svgPath = Path.Combine(dataDir, "input.svg");
            string outPptxPath = Path.Combine(dataDir, "output.pptx");

            // Read the SVG content from the file system
            string svgContent = File.ReadAllText(svgPath);

            // Create a new presentation
            Presentation pres = new Presentation();

            // Create an SvgImage object from the SVG content
            ISvgImage svgImage = new SvgImage(svgContent);

            // Add the SVG image to the presentation's image collection
            IPPImage ppImage = pres.Images.AddImage(svgImage);

            // Insert the SVG image onto the first slide as a picture frame
            pres.Slides[0].Shapes.AddPictureFrame(
                ShapeType.Rectangle,
                0,
                0,
                ppImage.Width,
                ppImage.Height,
                ppImage);

            // Save the presentation to the specified PPTX file
            pres.Save(outPptxPath, SaveFormat.Pptx);
        }
    }
}