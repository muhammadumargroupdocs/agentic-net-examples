using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace PresentationMediaExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PPTX file path
            string inputPath = "input.pptx";
            // Output SWF file path for extracted flash control
            string outputPath = "extracted_flash.swf";

            // Load the presentation
            Presentation pres = new Presentation(inputPath);

            // Get controls collection from the first slide
            IControlCollection controls = pres.Slides[0].Controls;

            // Variable to hold the flash control
            Control flashControl = null;

            // Find the flash control by name
            foreach (IControl control in controls)
            {
                if (control.Name == "ShockwaveFlash1")
                {
                    flashControl = (Control)control;
                    break;
                }
            }

            // If flash control is found, extract its binary data
            if (flashControl != null)
            {
                byte[] data = flashControl.ActiveXControlBinary;
                using (FileStream fs = new FileStream(outputPath, FileMode.Create, FileAccess.Write, FileShare.Read))
                {
                    fs.Write(data, 0, data.Length);
                }
            }

            // Save the presentation before exiting
            pres.Save("saved_output.pptx", SaveFormat.Pptx);
            pres.Dispose();
        }
    }
}