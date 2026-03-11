using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace RemoveCommentExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the input presentation
            string inputPath = "input.pptx";
            // Path to the output presentation
            string outputPath = "output.pptx";

            // Load the presentation
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
            {
                // Index of the slide containing the comment to remove (zero‑based)
                int slideIndex = 0;

                // Get the slide
                Aspose.Slides.ISlide slide = presentation.Slides[slideIndex];

                // Retrieve all comments on the slide
                Aspose.Slides.IComment[] comments = slide.GetSlideComments(null);

                // Check if there is at least one comment
                if (comments != null && comments.Length > 0)
                {
                    // Example: remove the first comment
                    Aspose.Slides.IComment commentToRemove = comments[0];
                    commentToRemove.Remove();
                }

                // Save the modified presentation
                presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
    }
}