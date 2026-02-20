using System;

namespace RemoveCommentsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define input and output file paths
            System.String dataDir = "C:\\Data\\";
            System.String inputPath = dataDir + "input.pptx";
            System.String outputPath = dataDir + "output.pptx";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Iterate through each slide and remove all comments
            for (int slideIndex = 0; slideIndex < presentation.Slides.Count; slideIndex++)
            {
                Aspose.Slides.ISlide slide = presentation.Slides[slideIndex];
                // Get all comments on the current slide
                Aspose.Slides.IComment[] slideComments = slide.GetSlideComments(null);
                // Remove each comment
                for (int commentIndex = 0; commentIndex < slideComments.Length; commentIndex++)
                {
                    slideComments[commentIndex].Remove();
                }
            }

            // Save the modified presentation
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}