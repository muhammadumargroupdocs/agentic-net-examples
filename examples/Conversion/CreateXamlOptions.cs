using System;
using Aspose.Slides;
using Aspose.Slides.Export.Xaml;

class Program
{
    static void Main()
    {
        // Load the PPTX presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Create XAML conversion options
        Aspose.Slides.Export.Xaml.XamlOptions xamlOptions = new Aspose.Slides.Export.Xaml.XamlOptions();
        xamlOptions.ExportHiddenSlides = true;

        // Save the presentation as XAML files using the specified options
        presentation.Save(xamlOptions);

        // Dispose the presentation object
        presentation.Dispose();
    }
}