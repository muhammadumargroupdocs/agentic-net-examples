using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Define the data directory and file names
        string dataDir = "Data";
        string inputFileName = "input.svg";
        string outputFileName = "output.pptx";

        // Build full paths for the SVG input and PPTX output
        string svgPath = Path.Combine(dataDir, inputFileName);
        string outPptxPath = Path.Combine(dataDir, outputFileName);

        // Read SVG content from the external file
        string svgContent = File.ReadAllText(svgPath);

        // Create a new presentation (contains one empty slide by default)
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Create an ISvgImage object from the SVG content
        Aspose.Slides.ISvgImage svgImage = new Aspose.Slides.SvgImage(svgContent);

        // Add the SVG image to the presentation and obtain a PPImage (IPPImage) instance
        Aspose.Slides.IPPImage ppImage = pres.Images.AddImage(svgImage);

        // Insert the image onto the first slide as a picture frame
        pres.Slides[0].Shapes.AddPictureFrame(
            Aspose.Slides.ShapeType.Rectangle,
            0,
            0,
            ppImage.Width,
            ppImage.Height,
            ppImage);

        // Save the presentation in PPTX format
        pres.Save(outPptxPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}