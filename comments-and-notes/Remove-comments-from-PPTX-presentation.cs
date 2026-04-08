using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        try
        {
            var inputPath = "input.pptx";
            var outputPath = "output_no_comments.pptx";

            using (var presentation = new Presentation(inputPath))
            {
                // Remove document-level comments
                presentation.DocumentProperties.Comments = string.Empty;

                // Save the presentation without comments
                presentation.Save(outputPath, SaveFormat.Pptx);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}