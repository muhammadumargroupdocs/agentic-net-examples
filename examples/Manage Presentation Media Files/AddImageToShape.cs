using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Set up data directory
        string dataDir = Path.Combine(Directory.GetCurrentDirectory(), "Data");
        if (!Directory.Exists(dataDir))
            Directory.CreateDirectory(dataDir);

        // Image file name and full path
        string imageFileName = "example.jpg";
        string imagePath = Path.Combine(dataDir, imageFileName);

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Load image and add to presentation's image collection
        Aspose.Slides.IImage img = Aspose.Slides.Images.FromFile(imagePath);
        Aspose.Slides.IPPImage imgx = pres.Images.AddImage(img);

        // Define shape dimensions
        float x = 100;
        float y = 100;
        float width = 400;
        float height = 300;

        // Add a rectangle shape to the slide
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, x, y, width, height);

        // Fill the shape with the picture and set stretch mode
        shape.FillFormat.FillType = Aspose.Slides.FillType.Picture;
        shape.FillFormat.PictureFillFormat.PictureFillMode = Aspose.Slides.PictureFillMode.Stretch;
        shape.FillFormat.PictureFillFormat.Picture.Image = imgx;

        // Apply stretch offsets (percentage values)
        shape.FillFormat.PictureFillFormat.StretchOffsetLeft = 0.1f;   // 10% inset from left
        shape.FillFormat.PictureFillFormat.StretchOffsetRight = 0.1f;  // 10% inset from right
        shape.FillFormat.PictureFillFormat.StretchOffsetTop = 0.05f;   // 5% inset from top
        shape.FillFormat.PictureFillFormat.StretchOffsetBottom = 0.05f; // 5% inset from bottom

        // Save the presentation
        string outPath = Path.Combine(dataDir, "output.pptx");
        pres.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);
        pres.Dispose();
    }
}