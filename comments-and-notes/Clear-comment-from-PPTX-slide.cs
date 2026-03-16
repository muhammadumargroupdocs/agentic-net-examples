using System;
using System.Collections.Generic;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        try
        {
            string inputPath = "input.pptx";
            string outputPath = "output.pptx";

            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
            {
                // Text of the comment that should be removed
                string targetCommentText = "Comment to remove";

                // Iterate through all comment authors
                foreach (Aspose.Slides.ICommentAuthor commentAuthor in presentation.CommentAuthors)
                {
                    // Collect comments to remove to avoid modifying the collection during iteration
                    List<Aspose.Slides.IComment> commentsToRemove = new List<Aspose.Slides.IComment>();

                    foreach (Aspose.Slides.IComment comment in commentAuthor.Comments)
                    {
                        Aspose.Slides.Comment concreteComment = comment as Aspose.Slides.Comment;
                        if (concreteComment != null && concreteComment.Text == targetCommentText)
                        {
                            commentsToRemove.Add(concreteComment);
                        }
                    }

                    // Remove the identified comments
                    foreach (Aspose.Slides.IComment comment in commentsToRemove)
                    {
                        comment.Remove();
                    }
                }

                // Save the modified presentation
                presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}