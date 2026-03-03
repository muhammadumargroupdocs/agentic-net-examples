using System;

namespace AsposeSlidesTiffConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the PowerPoint presentation from a file
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

            // Save the presentation as a multi‑page TIFF image
            presentation.Save("output.tiff", Aspose.Slides.Export.SaveFormat.Tiff);

            // Release resources
            presentation.Dispose();
        }
    }
}