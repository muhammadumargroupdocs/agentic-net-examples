using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Ensure data directory exists
        string dataDir = "Data";
        if (!System.IO.Directory.Exists(dataDir))
            System.IO.Directory.CreateDirectory(dataDir);

        // Path to the image file
        string imagePath = System.IO.Path.Combine(dataDir, "image.jpg");

        // Load image and add to presentation's image collection
        Aspose.Slides.IImage img = Aspose.Slides.Images.FromFile(imagePath);
        Aspose.Slides.IPPImage imgx = pres.Images.AddImage(img);

        // Add a picture frame to the slide
        Aspose.Slides.IPictureFrame pictureFrame = slide.Shapes.AddPictureFrame(
            Aspose.Slides.ShapeType.Rectangle,
            50, 50,
            imgx.Width, imgx.Height,
            imgx);

        // Rotate the picture frame (positive 45 degrees)
        pictureFrame.Rotation = 45f;

        // Save the presentation
        string outPath = System.IO.Path.Combine(dataDir, "RotatedPicture.pptx");
        pres.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        pres.Dispose();
    }
}