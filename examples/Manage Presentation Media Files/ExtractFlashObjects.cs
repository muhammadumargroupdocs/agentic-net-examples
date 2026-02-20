using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the input presentation
        string inputPath = "input.pptx";
        // Path to save the extracted flash binary
        string outputFlashPath = "flash.bin";
        // Path to save the (unchanged) presentation
        string outputPresentationPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);
        try
        {
            // Get the collection of controls on the first slide
            Aspose.Slides.IControlCollection controls = pres.Slides[0].Controls;
            Aspose.Slides.Control flashControl = null;

            // Find the flash control by name
            foreach (Aspose.Slides.IControl control in controls)
            {
                if (control.Name == "ShockwaveFlash1")
                {
                    flashControl = (Aspose.Slides.Control)control;
                    break;
                }
            }

            // If a flash control was found, extract its binary data
            if (flashControl != null)
            {
                byte[] data = flashControl.ActiveXControlBinary;
                using (FileStream fs = new FileStream(outputFlashPath, FileMode.Create, FileAccess.Write, FileShare.Read))
                {
                    fs.Write(data, 0, data.Length);
                }
            }

            // Save the presentation (even if unchanged) before exiting
            pres.Save(outputPresentationPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
        finally
        {
            // Ensure resources are released
            pres.Dispose();
        }
    }
}