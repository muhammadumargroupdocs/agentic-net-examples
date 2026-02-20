using System;
using System.IO;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define directories and file paths
        string dataDir = "Data";
        if (!Directory.Exists(dataDir))
            Directory.CreateDirectory(dataDir);
        string imagePath = Path.Combine(dataDir, "example.jpg");
        string outputPath = Path.Combine(dataDir, "output.pptx");

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Load the image from file
        Aspose.Slides.IImage image = Aspose.Slides.Images.FromFile(imagePath);
        Aspose.Slides.IPPImage imgx = pres.Images.AddImage(image);

        // Add a picture frame to the slide
        Aspose.Slides.IPictureFrame pictureFrame = slide.Shapes.AddPictureFrame(
            Aspose.Slides.ShapeType.Rectangle,
            50, 50,
            imgx.Width, imgx.Height,
            imgx);

        // Set line formatting for the picture frame
        pictureFrame.LineFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        pictureFrame.LineFormat.FillFormat.SolidFillColor.Color = Color.Blue;
        pictureFrame.LineFormat.Width = 5; // line width in points

        // Save the presentation
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        pres.Dispose();
    }
}