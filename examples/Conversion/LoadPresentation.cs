using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the PPT presentation from file
        using (var presentation = new Presentation("input.ppt"))
        {
            // Save the presentation in PPTX format
            presentation.Save("output.pptx", SaveFormat.Pptx);
        }
    }
}