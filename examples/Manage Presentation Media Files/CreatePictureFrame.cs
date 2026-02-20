using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define data directory
        string dataDir = "Data";
        if (!Directory.Exists(dataDir))
            Directory.CreateDirectory(dataDir);

        // Define image file name and path
        string imageFileName = "example.jpg";
        string imagePath = Path.Combine(dataDir, imageFileName);

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Load image and add to presentation images collection
        Aspose.Slides.IImage img = Aspose.Slides.Images.FromFile(imagePath);
        Aspose.Slides.IPPImage imgx = pres.Images.AddImage(img);

        // Add a rectangle auto shape
        float x = 100f;
        float y = 100f;
        float width = 400f;
        float height = 300f;
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, x, y, width, height);

        // Set picture fill and stretch offsets
        shape.FillFormat.FillType = Aspose.Slides.FillType.Picture;
        shape.FillFormat.PictureFillFormat.PictureFillMode = Aspose.Slides.PictureFillMode.Stretch;
        shape.FillFormat.PictureFillFormat.Picture.Image = imgx;
        shape.FillFormat.PictureFillFormat.StretchOffsetLeft = 0.1f;
        shape.FillFormat.PictureFillFormat.StretchOffsetRight = 0.1f;
        shape.FillFormat.PictureFillFormat.StretchOffsetTop = 0.1f;
        shape.FillFormat.PictureFillFormat.StretchOffsetBottom = 0.1f;

        // Save the presentation
        string outPath = Path.Combine(dataDir, "output.pptx");
        pres.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        pres.Dispose();
    }
}