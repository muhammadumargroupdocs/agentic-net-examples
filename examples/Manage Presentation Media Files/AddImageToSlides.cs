using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Output directory
        string outDir = "Output";
        if (!Directory.Exists(outDir))
            Directory.CreateDirectory(outDir);

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a heading rectangle shape with text
        Aspose.Slides.IAutoShape heading = slide.Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle,
            50f,   // X position
            20f,   // Y position
            600f,  // Width
            50f);  // Height
        heading.TextFrame.Text = "Slide Heading";

        // Load a local image file
        string imagePath = "image.jpg"; // Replace with your image file path
        Aspose.Slides.IImage image = Aspose.Slides.Images.FromFile(imagePath);
        Aspose.Slides.IPPImage ippImage = presentation.Images.AddImage(image);

        // Add the image to the slide as a picture frame
        slide.Shapes.AddPictureFrame(
            Aspose.Slides.ShapeType.Rectangle,
            50f,    // X position
            100f,   // Y position
            300f,   // Width
            200f,   // Height
            ippImage);

        // Save the presentation in PPTX format
        presentation.Save(Path.Combine(outDir, "Result.pptx"), Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        presentation.Dispose();
    }
}