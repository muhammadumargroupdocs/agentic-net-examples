using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Get absolute path to the data directory
        string dataDir = Path.GetFullPath("Data");
        // Combine data directory with input presentation file name
        string inputPath = Path.Combine(dataDir, "input.pptx");
        // Combine data directory with output presentation file name
        string outputPath = Path.Combine(dataDir, "output.pptm");

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Access the first slide (index 0)
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Access the first ActiveX control on the slide (index 0)
        Aspose.Slides.IControl control = slide.Controls[0];

        // Verify the control's name and that it has a properties collection
        if (control.Name == "MyControl" && control.Properties != null)
        {
            // Assign a new value to a property of the ActiveX control
            string propertyName = "Caption";
            control.Properties[propertyName] = "New Caption";
        }

        // Save the modified presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptm);
    }
}