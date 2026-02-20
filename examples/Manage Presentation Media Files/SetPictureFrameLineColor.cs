using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Define the image file path
        string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "sample.jpg");

        // Load the image
        Aspose.Slides.IImage image = Aspose.Slides.Images.FromFile(imagePath);

        // Add the image to the presentation's image collection
        Aspose.Slides.IPPImage imageX = presentation.Images.AddImage(image);

        // Define picture frame position
        float xPos = 50f;
        float yPos = 50f;

        // Add a picture frame to the slide
        Aspose.Slides.IPictureFrame pictureFrame = slide.Shapes.AddPictureFrame(
            Aspose.Slides.ShapeType.Rectangle,
            xPos,
            yPos,
            imageX.Width,
            imageX.Height,
            imageX);

        // Set line format to solid blue color
        pictureFrame.LineFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        pictureFrame.LineFormat.FillFormat.SolidFillColor.Color = System.Drawing.Color.Blue;
        pictureFrame.LineFormat.Width = 2.0f;

        // Optional rotation (set to 0)
        pictureFrame.Rotation = 0f;

        // Save the presentation
        string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "Output.pptx");
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}