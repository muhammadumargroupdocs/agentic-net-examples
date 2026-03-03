using System;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the PPTX presentation from file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");
        
        // Save the presentation to a new file
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        
        // Release resources
        presentation.Dispose();
    }
}