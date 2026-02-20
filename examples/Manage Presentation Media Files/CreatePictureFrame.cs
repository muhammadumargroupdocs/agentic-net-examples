using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Define data directory and ensure it exists
        string dataDir = "Data";
        if (!Directory.Exists(dataDir))
            Directory.CreateDirectory(dataDir);

        // Define input image path and output presentation path
        string imagePath = Path.Combine(dataDir, "example.jpg");
        string outputPath = Path.Combine(dataDir, "output.pptx");

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Load image from file
        Aspose.Slides.IImage img = Aspose.Slides.Images.FromFile(imagePath);

        // Add image to presentation's image collection
        Aspose.Slides.IPPImage imgx = pres.Images.AddImage(img);

        // Add picture frame using image's width and height
        Aspose.Slides.IPictureFrame pictureFrame = pres.Slides[0].Shapes.AddPictureFrame(
            Aspose.Slides.ShapeType.Rectangle,
            0, // X position
            0, // Y position
            imgx.Width,
            imgx.Height,
            imgx);

        // Save the presentation
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        pres.Dispose();
    }
}