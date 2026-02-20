using System;
using System.IO;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Path to the input presentation
        string inputPath = "input.pptx";
        // Path where the extracted flash file will be saved
        string outputPath = "flash.swf";

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

            // If found, extract its binary data and write to file
            if (flashControl != null)
            {
                byte[] data = flashControl.ActiveXControlBinary;
                using (System.IO.FileStream fs = new System.IO.FileStream(outputPath, System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.Read))
                {
                    fs.Write(data, 0, data.Length);
                }
            }
        }
        finally
        {
            // Save the presentation (if any modifications were made) before exiting
            pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
            pres.Dispose();
        }
    }
}