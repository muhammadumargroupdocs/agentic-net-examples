using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertPptxToSvg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Determine input file path
            string inputPath;
            if (args.Length > 0 && !String.IsNullOrEmpty(args[0]))
                inputPath = args[0];
            else
                inputPath = "input.pptx";

            // Prepare output directory and base file name
            string outputDirectory = Path.GetDirectoryName(inputPath);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(inputPath);

            // Load the presentation
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
            {
                // Iterate through each slide and save as SVG
                foreach (Aspose.Slides.ISlide slide in presentation.Slides)
                {
                    string svgFileName = String.Format("{0}_slide{1}.svg", fileNameWithoutExtension, slide.SlideNumber);
                    string svgFilePath = Path.Combine(outputDirectory, svgFileName);

                    using (FileStream svgStream = new FileStream(svgFilePath, FileMode.Create))
                    {
                        SVGOptions svgOptions = new SVGOptions();
                        slide.WriteAsSvg(svgStream, svgOptions);
                    }
                }

                // Save the (potentially unchanged) presentation before exiting
                string savedPresentationPath = Path.Combine(outputDirectory, fileNameWithoutExtension + "_saved.pptx");
                presentation.Save(savedPresentationPath, SaveFormat.Pptx);
            }
        }
    }
}