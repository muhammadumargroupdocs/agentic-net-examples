using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertPptToSvg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Determine input file path
            string inputPath;
            if (args.Length > 0 && !String.IsNullOrEmpty(args[0]))
            {
                inputPath = args[0];
            }
            else
            {
                inputPath = "input.pptx"; // default file name
            }

            // Load the presentation
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
            {
                // Iterate through each slide and save as SVG
                foreach (Aspose.Slides.ISlide slide in presentation.Slides)
                {
                    string svgFileName = String.Format("slide_{0}.svg", slide.SlideNumber);
                    using (FileStream fileStream = new FileStream(svgFileName, FileMode.Create, FileAccess.Write))
                    {
                        // Save the slide as SVG using default SVG options
                        slide.WriteAsSvg(fileStream, new Aspose.Slides.Export.SVGOptions());
                    }
                }

                // Save the presentation before exiting (optional, as per lifecycle rule)
                presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
    }
}