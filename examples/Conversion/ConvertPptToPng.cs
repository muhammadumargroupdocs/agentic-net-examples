using System;
using System.IO;
using System.Drawing.Imaging;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Input PPT/PPTX file path
        string inputPath = "example.pptx";

        // Output folder for PNG images
        string outputFolder = "output";
        Directory.CreateDirectory(outputFolder);

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Scale factors for thumbnail generation (1 = original size)
        int scaleX = 1;
        int scaleY = 1;

        // Iterate through each slide and save as PNG
        foreach (Aspose.Slides.ISlide slide in pres.Slides)
        {
            // Generate image for the slide
            Aspose.Slides.IImage thumbnail = slide.GetImage(scaleX, scaleY);

            // Build PNG file name using slide number
            string imageFileName = String.Format(Path.Combine(outputFolder, "slide_{0}.png"), slide.SlideNumber);

            // Save the image as PNG
            thumbnail.Save(imageFileName, ImageFormat.Png);
        }

        // Save the presentation before exiting (optional, can be same or different format)
        pres.Save("converted_output.pptx", SaveFormat.Pptx);

        // Dispose the presentation object
        pres.Dispose();
    }
}