using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Set up data directory
        string dataDir = "Data";
        if (!Directory.Exists(dataDir))
            Directory.CreateDirectory(dataDir);

        // Path to the source image
        string imagePath = Path.Combine(dataDir, "example.jpg");

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Load the image from file
        Aspose.Slides.IImage img = Aspose.Slides.Images.FromFile(imagePath);

        // Add the image to the presentation's image collection
        Aspose.Slides.IPPImage imgx = pres.Images.AddImage(img);

        // Define picture frame position (top-left corner)
        float x = 0f;
        float y = 0f;

        // Use the image's original width and height for the picture frame
        float width = imgx.Width;
        float height = imgx.Height;

        // Add picture frame to the slide using the image dimensions
        Aspose.Slides.IPictureFrame pictureFrame = slide.Shapes.AddPictureFrame(
            Aspose.Slides.ShapeType.Rectangle,
            x,
            y,
            width,
            height,
            imgx);

        // Save the presentation
        string outPath = Path.Combine(dataDir, "output.pptx");
        pres.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        pres.Dispose();
    }
}