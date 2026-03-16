using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        try
        {
            string inputPath = "input.pptx";
            string outputDirectory = "output";
            Directory.CreateDirectory(outputDirectory);

            using (Presentation presentation = new Presentation(inputPath))
            {
                int slideCount = presentation.Slides.Count;
                for (int index = 0; index < slideCount; index++)
                {
                    ISlide slide = presentation.Slides[index];
                    // Render slide with full scale to preserve 3D visual fidelity
                    IImage slideImage = slide.GetImage(1f, 1f);
                    string outputPath = Path.Combine(outputDirectory, $"slide_{index + 1}.png");
                    slideImage.Save(outputPath, Aspose.Slides.ImageFormat.Png);
                    slideImage.Dispose();
                }

                // Save the (potentially modified) presentation before exiting
                string savedPresentationPath = Path.Combine(outputDirectory, "processed.pptx");
                presentation.Save(savedPresentationPath, SaveFormat.Pptx);
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine("An error occurred: " + exception.Message);
        }
    }
}