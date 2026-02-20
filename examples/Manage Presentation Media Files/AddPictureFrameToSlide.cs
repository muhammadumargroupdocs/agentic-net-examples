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

        // Define image file name and path
        string imageFileName = "example.jpg";
        string imagePath = Path.Combine(dataDir, imageFileName);

        // Read image bytes
        byte[] imageData = File.ReadAllBytes(imagePath);

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Add image to the presentation's image collection
        Aspose.Slides.IPPImage img = pres.Images.AddImage(imageData);

        // Get the first slide or add a blank slide if none exist
        Aspose.Slides.ISlide slide;
        if (pres.Slides.Count > 0)
            slide = pres.Slides[0];
        else
            slide = pres.Slides.AddEmptySlide(pres.LayoutSlides.GetByType(Aspose.Slides.SlideLayoutType.Blank));

        // Add a picture frame that fills the whole slide
        slide.Shapes.AddPictureFrame(
            Aspose.Slides.ShapeType.Rectangle,
            0,
            0,
            pres.SlideSize.Size.Width,
            pres.SlideSize.Size.Height,
            img);

        // Save the presentation
        string outPath = Path.Combine(dataDir, "output.pptx");
        pres.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        pres.Dispose();
    }
}