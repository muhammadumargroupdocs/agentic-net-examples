using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Vba;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input PPTX file containing VBA macros
        string inputPath = "input.pptm";

        // Directory to store extracted macro files
        string outputDir = "ExtractedMacros";
        if (!Directory.Exists(outputDir))
        {
            Directory.CreateDirectory(outputDir);
        }

        // Load the presentation
        Presentation presentation = new Presentation(inputPath);
        try
        {
            // Access the VBA project
            Aspose.Slides.Vba.IVbaProject vbaProject = presentation.VbaProject;
            if (vbaProject != null)
            {
                // Iterate through all modules and save their source code
                Aspose.Slides.Vba.IVbaModuleCollection modules = vbaProject.Modules;
                int moduleIndex = 0;
                foreach (Aspose.Slides.Vba.IVbaModule module in modules)
                {
                    string sourceCode = module.SourceCode;
                    string fileName = Path.Combine(outputDir, "Module_" + moduleIndex + "_" + module.Name + ".bas");
                    File.WriteAllText(fileName, sourceCode);
                    moduleIndex++;
                }
            }
        }
        finally
        {
            // Save the presentation before exiting
            presentation.Save("output.pptx", SaveFormat.Pptx);
            presentation.Dispose();
        }
    }
}