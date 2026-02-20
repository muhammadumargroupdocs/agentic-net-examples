using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Input and output file paths
        System.String inputPath = "input.pptx";
        System.String outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Iterate through all comment authors
        for (int authorIndex = 0; authorIndex < presentation.CommentAuthors.Count; authorIndex++)
        {
            Aspose.Slides.ICommentAuthor author = presentation.CommentAuthors[authorIndex];

            // Get a copy of the author's comments
            Aspose.Slides.IComment[] comments = author.Comments.ToArray();

            // Remove comments that match a specific condition (e.g., text equals "DeleteMe")
            foreach (Aspose.Slides.IComment comment in comments)
            {
                if (comment.Text == "DeleteMe")
                {
                    comment.Remove();
                }
            }
        }

        // Save the modified presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation object
        presentation.Dispose();
    }
}