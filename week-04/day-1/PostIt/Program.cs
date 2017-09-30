using System;

namespace PostIt
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt postIt1, postIt2, postIt3;
            postIt1.Text = "Idea 1";
            postIt2.Text = "Awesome";
            postIt3.Text = "Superb!";

			postIt1.TextColor = "blue";
			postIt2.TextColor = "black";
			postIt3.TextColor = "green";

			postIt1.BackgroundColor = "orange";
			postIt2.BackgroundColor = "pink";
			postIt3.BackgroundColor = "yellow";


		}
    }
}
