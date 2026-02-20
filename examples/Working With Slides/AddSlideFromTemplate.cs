using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define paths
        string dataDir = "C:\\Data\\";
        string templatePath = dataDir + "Template.pptx";
        string outputPath = dataDir + "Result.pptx";

        // Load the template presentation
        Presentation templatePresentation = new Presentation(templatePath);

        // Create a new presentation (target)
        Presentation targetPresentation = new Presentation();

        // Get the first slide from the template
        ISlide templateSlide = templatePresentation.Slides[0];

        // Add a clone of the template slide to the target presentation
        targetPresentation.Slides.AddClone(templateSlide);

        // Save the target presentation
        targetPresentation.Save(outputPath, SaveFormat.Pptx);

        // Clean up
        templatePresentation.Dispose();
        targetPresentation.Dispose();
    }
}