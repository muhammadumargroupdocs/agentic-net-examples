using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Input PowerPoint file
        System.String inputPath = "input.pptx";

        // Output file name pattern for PNG images
        System.String outputFormat = "slide_{0}.png";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Iterate through each slide and export to PNG
        for (int index = 0; index < pres.Slides.Count; index++)
        {
            Aspose.Slides.ISlide slide = pres.Slides[index];
            using (Aspose.Slides.IImage image = slide.GetImage())
            {
                System.String outputPath = System.String.Format(outputFormat, index);
                image.Save(outputPath, Aspose.Slides.ImageFormat.Png);
            }
        }

        // Save the presentation (required by authoring rules)
        pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}