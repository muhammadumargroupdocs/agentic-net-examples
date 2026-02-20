using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace PresentationMediaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define data directory
            string dataDir = Path.Combine(Directory.GetCurrentDirectory(), "Data");
            // Define image and output file paths
            string imagePath = Path.Combine(dataDir, "example.jpg");
            string outputPath = Path.Combine(dataDir, "output.pptx");

            // Ensure the data directory exists
            if (!Directory.Exists(dataDir))
                Directory.CreateDirectory(dataDir);

            // Create a new presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

            // Get the first slide
            Aspose.Slides.ISlide slide = pres.Slides[0];

            // Add a rectangle shape
            Aspose.Slides.IShape shape = slide.Shapes.AddAutoShape(
                Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 300);

            // Set the shape's fill type to picture
            shape.FillFormat.FillType = Aspose.Slides.FillType.Picture;

            // Load the image from file
            Aspose.Slides.IImage img = Aspose.Slides.Images.FromFile(imagePath);

            // Add the image to the presentation's image collection
            Aspose.Slides.IPPImage ppImg = pres.Images.AddImage(img);

            // Assign the image to the shape's picture fill format
            shape.FillFormat.PictureFillFormat.Picture.Image = ppImg;

            // Set the picture fill mode to Tile
            shape.FillFormat.PictureFillFormat.PictureFillMode = Aspose.Slides.PictureFillMode.Tile;

            // Save the presentation
            pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}