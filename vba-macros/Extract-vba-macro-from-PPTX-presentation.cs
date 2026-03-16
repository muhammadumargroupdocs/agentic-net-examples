using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.Vba;

class Program
{
    static void Main()
    {
        // Path to the input presentation (must be a macro-enabled file, e.g., .pptm)
        string inputPath = "input.pptm";
        // Path where the presentation will be saved after processing
        string outputPath = "output.pptm";

        Aspose.Slides.Presentation presentation = null;
        try
        {
            // Load the presentation
            presentation = new Aspose.Slides.Presentation(inputPath);

            // Access the VBA project
            Aspose.Slides.Vba.IVbaProject vbaProject = presentation.VbaProject;
            if (vbaProject != null)
            {
                int moduleCount = vbaProject.Modules.Count;
                Console.WriteLine("Number of VBA modules: " + moduleCount);
                for (int i = 0; i < moduleCount; i++)
                {
                    Aspose.Slides.Vba.IVbaModule module = vbaProject.Modules[i];
                    Console.WriteLine("Module Name: " + module.Name);
                    Console.WriteLine("Source Code:");
                    Console.WriteLine(module.SourceCode);
                    Console.WriteLine(new string('-', 40));
                }
            }
            else
            {
                Console.WriteLine("No VBA project found in the presentation.");
            }

            // Save the (unchanged) presentation to the output file
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptm);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            // Ensure resources are released
            if (presentation != null)
            {
                presentation.Dispose();
            }
        }
    }
}