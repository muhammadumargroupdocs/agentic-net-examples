using System;
using System.IO;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Output directory
        string outDir = "Output";
        if (!Directory.Exists(outDir))
            Directory.CreateDirectory(outDir);

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Load image file
        string imagePath = "heading.png";
        Aspose.Slides.IImage image = Aspose.Slides.Images.FromFile(imagePath);
        Aspose.Slides.IPPImage ippImage = presentation.Images.AddImage(image);

        // Get the first master slide
        Aspose.Slides.IMasterSlide masterSlide = presentation.Masters[0];

        // Add picture frame to the master slide (heading)
        float x = 0;
        float y = 0;
        float width = 500;
        float height = 100;
        masterSlide.Shapes.AddPictureFrame(Aspose.Slides.ShapeType.Rectangle, x, y, width, height, ippImage);

        // Save the presentation
        string outPath = Path.Combine(outDir, "MasterWithImage.pptx");
        presentation.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}