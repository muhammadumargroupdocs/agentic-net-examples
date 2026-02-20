using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Define the data directory
        string dataDir = "./Data";
        if (!Directory.Exists(dataDir))
            Directory.CreateDirectory(dataDir);

        // Path to the image file
        string imagePath = Path.Combine(dataDir, "sample.jpg");

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Load the image and add it to the presentation's image collection
        Aspose.Slides.IImage img = Aspose.Slides.Images.FromFile(imagePath);
        Aspose.Slides.IPPImage imgx = pres.Images.AddImage(img);

        // Add a rectangle shape that will hold the picture
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 300);

        // Set the fill type to picture and configure stretch mode
        shape.FillFormat.FillType = Aspose.Slides.FillType.Picture;
        shape.FillFormat.PictureFillFormat.PictureFillMode = Aspose.Slides.PictureFillMode.Stretch;
        shape.FillFormat.PictureFillFormat.Picture.Image = imgx;

        // Apply stretch offsets (percentage values)
        shape.FillFormat.PictureFillFormat.StretchOffsetLeft = 0.1f;
        shape.FillFormat.PictureFillFormat.StretchOffsetRight = 0.1f;
        shape.FillFormat.PictureFillFormat.StretchOffsetTop = 0.1f;
        shape.FillFormat.PictureFillFormat.StretchOffsetBottom = 0.1f;

        // Save the presentation
        string outPath = Path.Combine(dataDir, "output.pptx");
        pres.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);
        pres.Dispose();
    }
}