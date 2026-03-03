using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PPTX file
        string sourcePath = "input.pptx";
        // Path to the output XPS file
        string outputPath = "output.xps";

        // Load the presentation from the PPTX file
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath))
        {
            // Save the presentation to XPS format using default options
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Xps);
        }

        // Example of using custom XPS options (optional)
        // using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath))
        // {
        //     Aspose.Slides.Export.XpsOptions options = new Aspose.Slides.Export.XpsOptions();
        //     options.SaveMetafilesAsPng = true; // Convert metafiles to PNG
        //     presentation.Save("output_custom.xps", Aspose.Slides.Export.SaveFormat.Xps, options);
        // }
    }
}