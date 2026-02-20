using System;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PPTX file
        string inputPath = "input.pptx";
        // Format string for the output JPEG files
        string outputFormat = "slide_{0}.jpg";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Scale factors for the image (1 = original size)
        int scaleX = 1;
        int scaleY = scaleX;

        // Render each slide as a JPEG image
        foreach (Aspose.Slides.ISlide slide in presentation.Slides)
        {
            using (Aspose.Slides.IImage image = slide.GetImage(scaleX, scaleY))
            {
                string imageFileName = string.Format(outputFormat, slide.SlideNumber);
                image.Save(imageFileName, Aspose.Slides.ImageFormat.Jpeg);
            }
        }

        // Save the presentation before exiting (no modifications made)
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}