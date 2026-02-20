using System;
using System.IO;
using System.Collections.Generic;
using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.Util;

namespace ManageTextBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define input and output paths
            string dataDir = "Data";
            string outDir = "Output";

            // Ensure the output directory exists
            if (!Directory.Exists(outDir))
                Directory.CreateDirectory(outDir);

            // Load an existing PPTX presentation
            Presentation presentation = new Presentation(Path.Combine(dataDir, "input.pptx"));

            // Get all text boxes from the first slide
            IEnumerable<ITextFrame> textFrames = SlideUtil.GetAllTextBoxes(presentation.Slides[0]);

            // Update the text of each text box
            foreach (ITextFrame textFrame in textFrames)
            {
                textFrame.Text = "Updated Text";
            }

            // Save the modified presentation as PPTX
            presentation.Save(Path.Combine(outDir, "output.pptx"), SaveFormat.Pptx);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}