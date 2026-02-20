using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Define the directory for data files
        string dataDir = "Data";
        if (!Directory.Exists(dataDir))
            Directory.CreateDirectory(dataDir);

        // Define input image path and output presentation path
        string imagePath = Path.Combine(dataDir, "example.jpg");
        string outPath = Path.Combine(dataDir, "output.pptx");

        // Create a new presentation
        Presentation pres = new Presentation();

        // Get the first slide
        ISlide slide = pres.Slides[0];

        // Load the image from file
        IImage img = Images.FromFile(imagePath);
        IPPImage imgx = pres.Images.AddImage(img);

        // Add a rectangle auto shape to the slide
        IAutoShape shape = slide.Shapes.AddAutoShape(ShapeType.Rectangle, 50, 50, 400, 300);

        // Set the fill type to picture and use stretch mode
        shape.FillFormat.FillType = FillType.Picture;
        shape.FillFormat.PictureFillFormat.PictureFillMode = PictureFillMode.Stretch;

        // Assign the image to the picture fill
        shape.FillFormat.PictureFillFormat.Picture.Image = imgx;

        // Set stretch offsets (percentage values)
        shape.FillFormat.PictureFillFormat.StretchOffsetLeft = 10f;   // inset 10% from left
        shape.FillFormat.PictureFillFormat.StretchOffsetRight = -5f; // outset 5% from right
        shape.FillFormat.PictureFillFormat.StretchOffsetTop = 15f;   // inset 15% from top
        shape.FillFormat.PictureFillFormat.StretchOffsetBottom = 0f; // no offset at bottom

        // Save the presentation
        pres.Save(outPath, SaveFormat.Pptx);

        // Clean up
        pres.Dispose();
    }
}