using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Load the PPTX presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Generate animations (optional step to process animated content)
        using (Aspose.Slides.Export.PresentationAnimationsGenerator animationsGenerator = new Aspose.Slides.Export.PresentationAnimationsGenerator(presentation))
        {
            animationsGenerator.Run(presentation.Slides);
        }

        // Export the presentation to PDF
        presentation.Save("output.pdf", Aspose.Slides.Export.SaveFormat.Pdf);
    }
}