using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input presentation path
        System.String inputPath = "input.pptx";
        // Load presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);
        // Output directory for extracted flash data
        System.String outputDir = "output";
        System.IO.Directory.CreateDirectory(outputDir);
        // Output file for flash binary
        System.String outputPath = System.IO.Path.Combine(outputDir, "flash.bin");
        // FileStream to write flash data
        System.IO.FileStream fs = new System.IO.FileStream(outputPath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
        try
        {
            // Get controls from the first slide
            Aspose.Slides.IControlCollection controls = pres.Slides[0].Controls;
            Aspose.Slides.Control flashControl = null;
            foreach (Aspose.Slides.IControl control in controls)
            {
                if (control.Name == "ShockwaveFlash1")
                {
                    flashControl = (Aspose.Slides.Control)control;
                    break;
                }
            }
            // If flash control found, extract its binary data
            if (flashControl != null)
            {
                System.Byte[] data = flashControl.ActiveXControlBinary;
                fs.Write(data, 0, data.Length);
            }
        }
        finally
        {
            fs.Dispose();
        }
        // Save the presentation before exiting
        System.String savedPath = System.IO.Path.Combine(outputDir, "presentation_saved.pptx");
        pres.Save(savedPath, Aspose.Slides.Export.SaveFormat.Pptx);
        pres.Dispose();
    }
}