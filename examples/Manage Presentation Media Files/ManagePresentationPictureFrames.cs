using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define output directory
        string outDir = "Output";
        if (!Directory.Exists(outDir))
        {
            Directory.CreateDirectory(outDir);
        }

        // Path to the image file to be added
        string imagePath = "sample.jpg";

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Load image from file stream and add it to the presentation's image collection
        FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
        Aspose.Slides.IPPImage img = pres.Images.AddImage(fs, Aspose.Slides.LoadingStreamBehavior.KeepLocked);
        fs.Close();

        // Add a picture frame to the first slide using the added image
        Aspose.Slides.IShape pictureFrame = pres.Slides[0].Shapes.AddPictureFrame(
            Aspose.Slides.ShapeType.Rectangle,
            50, 50, 400, 300,
            img);

        // Save the presentation before exiting
        string outPath = Path.Combine(outDir, "PictureFrameDemo.pptx");
        pres.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation object
        pres.Dispose();
    }
}