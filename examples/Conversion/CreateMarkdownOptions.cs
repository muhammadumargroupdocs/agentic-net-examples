using System;

class Program
{
    static void Main()
    {
        // Load the PPTX presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx"))
        {
            // Create and configure Markdown save options
            Aspose.Slides.Export.MarkdownSaveOptions markdownOptions = new Aspose.Slides.Export.MarkdownSaveOptions();
            markdownOptions.ShowHiddenSlides = true;
            markdownOptions.ShowSlideNumber = true;
            markdownOptions.Flavor = Aspose.Slides.Export.Flavor.Github;
            markdownOptions.ExportType = Aspose.Slides.Export.MarkdownExportType.Sequential;
            markdownOptions.NewLineType = Aspose.Slides.Export.NewLineType.Windows;

            // Prepare slide indices (1‑based)
            int slideCount = presentation.Slides.Count;
            int[] slideIndices = new int[slideCount];
            for (int i = 0; i < slideCount; i++)
            {
                slideIndices[i] = i + 1;
            }

            // Save the presentation as Markdown
            presentation.Save("output.md", slideIndices, Aspose.Slides.Export.SaveFormat.Md, markdownOptions);
        }
    }
}