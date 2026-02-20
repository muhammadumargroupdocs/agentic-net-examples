class Program
{
    static void Main()
    {
        // Input and output presentation files
        System.String inputPath = "input.pptx";
        System.String outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Define source font (to be replaced) and destination font (replacement)
        Aspose.Slides.IFontData sourceFont = new Aspose.Slides.FontData("Arial");
        Aspose.Slides.IFontData destFont = new Aspose.Slides.FontData("Calibri");

        // Perform font replacement
        presentation.FontsManager.ReplaceFont(sourceFont, destFont);

        // Save the modified presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        presentation.Dispose();
    }
}