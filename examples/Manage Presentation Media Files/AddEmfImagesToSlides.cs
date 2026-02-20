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

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Path to the EMF image file
        string emfPath = Path.Combine("Images", "heading.emf");

        // Read EMF image bytes
        byte[] emfData = File.ReadAllBytes(emfPath);

        // Add EMF image to the presentation's image collection
        Aspose.Slides.IPPImage emfImage = presentation.Images.AddImage(emfData);

        // Define picture frame position and size
        float x = 50f;
        float y = 50f;
        float width = 400f;
        float height = 100f;

        // Add picture frame with the EMF image to the slide
        slide.Shapes.AddPictureFrame(Aspose.Slides.ShapeType.Rectangle, x, y, width, height, emfImage);

        // Save the presentation as PPTX
        string pptxPath = Path.Combine(outDir, "HeadingEmf.pptx");
        presentation.Save(pptxPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        presentation.Dispose();
    }
}