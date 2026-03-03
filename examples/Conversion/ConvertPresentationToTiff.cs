using System;

class Program
{
    static void Main(string[] args)
    {
        // Load the source presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");
        
        // Convert and save the presentation as a multi‑page TIFF file
        presentation.Save("output.tiff", Aspose.Slides.Export.SaveFormat.Tiff);
        
        // Release resources
        presentation.Dispose();
    }
}