class Program
{
    static void Main()
    {
        // Input PPT file path
        System.String inputPath = "input.ppt";
        // Output PPTX file path
        System.String outputPath = "output.pptx";

        // Load the PPT presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Save the presentation in PPTX format
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Release resources
        presentation.Dispose();
    }
}