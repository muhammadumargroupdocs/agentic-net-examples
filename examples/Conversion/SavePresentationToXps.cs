using System;

class Program
{
    static void Main()
    {
        // Input and output file paths
        var presentationPath = "input.pptx";
        var outputPath = "output.xps";

        // Load the presentation and save it as XPS
        using (var pres = new Aspose.Slides.Presentation(presentationPath))
        {
            pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Xps);
        }
    }
}