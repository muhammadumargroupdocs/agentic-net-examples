using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Define paths
        string dataDir = "Data";
        if (!Directory.Exists(dataDir))
        {
            Directory.CreateDirectory(dataDir);
        }
        string inputPath = Path.Combine(dataDir, "image.jpg");
        string outputPath = Path.Combine(dataDir, "output.pptx");

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Load image from file
        Aspose.Slides.IImage img = Aspose.Slides.Images.FromFile(inputPath);

        // Add image to presentation's image collection
        Aspose.Slides.IPPImage image = pres.Images.AddImage(img);

        // Define picture frame position and size using the image's original dimensions
        float x = 0f;
        float y = 0f;
        float width = (float)image.Width;
        float height = (float)image.Height;

        // Add picture frame to the first slide
        Aspose.Slides.IPictureFrame pf = pres.Slides[0].Shapes.AddPictureFrame(
            Aspose.Slides.ShapeType.Rectangle,
            x,
            y,
            width,
            height,
            image);

        // Set scale to 100% (optional)
        pf.RelativeScaleWidth = 1.0f;
        pf.RelativeScaleHeight = 1.0f;

        // Save the presentation
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up
        pres.Dispose();
    }
}