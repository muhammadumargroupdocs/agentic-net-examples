using System;

class Program
{
    static void Main()
    {
        // Path to the source presentation
        System.String inputPath = "input.pptx";
        // Format string for output PNG files (e.g., slide_0.png, slide_1.png, ...)
        System.String outputFormat = "slide_{0}.png";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Iterate through each slide and export it as a PNG image
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