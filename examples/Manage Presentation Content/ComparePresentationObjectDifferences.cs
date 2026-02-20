using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load an existing presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation("input.pptx");

        // Create rendering options to control ink appearance
        Aspose.Slides.Export.RenderingOptions renderOpts = new Aspose.Slides.Export.RenderingOptions();

        // Hide ink objects in the exported PPT
        renderOpts.InkOptions.HideInk = true;
        renderOpts.InkOptions.InterpretMaskOpAsOpacity = false;

        // Save presentation with hidden ink
        pres.Save("output_hidden.ppt", Aspose.Slides.Export.SaveFormat.Ppt, renderOpts);

        // Show ink objects in the exported PPT
        renderOpts.InkOptions.HideInk = false;
        renderOpts.InkOptions.InterpretMaskOpAsOpacity = true;

        // Save presentation with visible ink
        pres.Save("output_visible.ppt", Aspose.Slides.Export.SaveFormat.Ppt, renderOpts);

        // Release resources
        pres.Dispose();
    }
}