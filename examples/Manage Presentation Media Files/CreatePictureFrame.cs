using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define directories and file paths
        string dataDir = "Data";
        if (!Directory.Exists(dataDir))
        {
            Directory.CreateDirectory(dataDir);
        }
        string imagePath = Path.Combine(dataDir, "example.jpg");
        string outputPath = Path.Combine(dataDir, "output.pptx");

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Load image from file and add it to the presentation's image collection
        Aspose.Slides.IImage img = Aspose.Slides.Images.FromFile(imagePath);
        Aspose.Slides.IPPImage image = presentation.Images.AddImage(img);

        // Add a picture frame to the first slide with initial size and position
        Aspose.Slides.IPictureFrame pictureFrame = presentation.Slides[0].Shapes.AddPictureFrame(
            Aspose.Slides.ShapeType.Rectangle,
            50,    // X position
            50,    // Y position
            400,   // Width
            300,   // Height
            image);

        // Set relative scaling for the picture frame (50% of original size)
        pictureFrame.RelativeScaleHeight = 0.5f;
        pictureFrame.RelativeScaleWidth = 0.5f;

        // Save the presentation to PPTX format
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}