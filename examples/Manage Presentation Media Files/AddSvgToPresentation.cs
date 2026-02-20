using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Paths for SVG file and output presentation
        string dataDir = Environment.CurrentDirectory;
        string svgFilePath = Path.Combine(dataDir, "example.svg");
        string outputPath = Path.Combine(dataDir, "output.pptx");

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Load SVG image and add it to the presentation's image collection
        Aspose.Slides.ISvgImage svgImage = new Aspose.Slides.SvgImage(svgFilePath);
        Aspose.Slides.IPPImage pptxImage = presentation.Images.AddImage(svgImage);

        // Insert the SVG image as a picture shape on the first slide
        Aspose.Slides.IShape pictureShape = presentation.Slides[0].Shapes.AddPictureFrame(
            Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 300, pptxImage);

        // Save the presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}