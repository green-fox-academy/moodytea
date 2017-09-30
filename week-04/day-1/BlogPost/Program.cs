using System;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogPostClass blogPost1 = new BlogPostClass();
            BlogPostClass blogPost2 = new BlogPostClass();
            BlogPostClass blogPost3 = new BlogPostClass();


            blogPost1.Title = "Lorem Ipsum";
            blogPost1.Text = "Lorem ipsum dolor sit amet.";
            blogPost1.PublicationDate = "2000.05.04.";

			blogPost2.AuthorName = "Tim Urban";
			blogPost2.Title = "Wait but why";
			blogPost2.Text = "A popular long-form, stick-figure-illustrated blog about almost everything.";
			blogPost2.PublicationDate = "2010.10.10.";

			blogPost3.AuthorName = "William Turton";
			blogPost3.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
			blogPost3.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.";
			blogPost3.PublicationDate = "2017.03.28.";

			
        }
    }
}
