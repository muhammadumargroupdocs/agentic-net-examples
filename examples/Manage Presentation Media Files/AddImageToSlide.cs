using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Path to the local image file
        string imagePath = "image.jpg";
        // Path where the presentation will be saved
        string outputPath = "output.pptx";

        // Create a new presentation
        Presentation pres = new Presentation();

        // Open the image file as a stream
        using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
        {
            // Add the image to the presentation's image collection
            IPPImage img = pres.Images.AddImage(fs, LoadingStreamBehavior.KeepLocked);

            // Add the image to the first slide as a picture frame
            pres.Slides[0].Shapes.AddPictureFrame(ShapeType.Rectangle, 0, 0, img.Width, img.Height, img);
        }

        // Save the presentation
        pres.Save(outputPath, SaveFormat.Pptx);
    }
}