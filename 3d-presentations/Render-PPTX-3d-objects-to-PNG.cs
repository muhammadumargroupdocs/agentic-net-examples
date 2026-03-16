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
            string outputFolder = "output_images";
            Directory.CreateDirectory(outputFolder);

            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);
            float scaleX = 2f;
            float scaleY = 2f;

            for (int i = 0; i < presentation.Slides.Count; i++)
            {
                Aspose.Slides.ISlide slide = presentation.Slides[i];
                Aspose.Slides.IImage image = slide.GetImage(scaleX, scaleY);
                string imagePath = Path.Combine(outputFolder, $"slide_{i + 1}.png");
                image.Save(imagePath, Aspose.Slides.ImageFormat.Png);
                image.Dispose();
            }

            presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
            presentation.Dispose();
        }
        catch (Aspose.Slides.PptxReadException ex)
        {
            Console.WriteLine("Error reading PPTX file: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}