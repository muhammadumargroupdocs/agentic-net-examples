using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Define the directory containing the presentations
        System.String dataDir = @"C:\Data\";

        // Define file paths
        System.String templatePath = Path.Combine(dataDir, "template.pptx");
        System.String targetPath = Path.Combine(dataDir, "target.pptx");
        System.String outputPath = Path.Combine(dataDir, "output.pptx");

        // Load the template presentation
        using (Aspose.Slides.Presentation templatePres = new Aspose.Slides.Presentation(templatePath))
        {
            // Load the target presentation
            using (Aspose.Slides.Presentation targetPres = new Aspose.Slides.Presentation(targetPath))
            {
                // Get the first slide from the template
                Aspose.Slides.ISlide sourceSlide = templatePres.Slides[0];

                // Add a clone of the template slide to the target presentation
                targetPres.Slides.AddClone(sourceSlide);

                // Save the updated presentation
                targetPres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
    }
}