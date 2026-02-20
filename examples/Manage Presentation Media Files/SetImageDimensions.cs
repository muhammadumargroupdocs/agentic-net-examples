using System;
using System.IO;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Define directories and file paths
        string dataDir = "Data";
        if (!Directory.Exists(dataDir))
            Directory.CreateDirectory(dataDir);
        string imagePath = Path.Combine(dataDir, "image.jpg");
        string outputPath = Path.Combine(dataDir, "output.pptx");

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Load image from file and add it to the presentation's image collection
        Aspose.Slides.IImage img = Aspose.Slides.Images.FromFile(imagePath);
        Aspose.Slides.IPPImage image = pres.Images.AddImage(img);

        // Add a picture frame shape to the first slide
        Aspose.Slides.IPictureFrame pf = pres.Slides[0].Shapes.AddPictureFrame(
            Aspose.Slides.ShapeType.Rectangle,
            50,    // X position
            50,    // Y position
            400,   // Width
            300,   // Height
            image);

        // Set relative width and height scaling (e.g., 50% of original size)
        pf.RelativeScaleHeight = 0.5f;
        pf.RelativeScaleWidth = 0.5f;

        // Save the presentation
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        pres.Dispose();
    }
}