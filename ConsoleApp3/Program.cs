using System;

namespace ConsoleApp3
{
    class Program
    {
        
        public class blogPost
        {

        

        {
            public int PostScore;                     
            public string content;
            public string title;

            public getTitle()
            {

            }
            public getContent()
            {

            }
            
            public void upVote(ref int postUpvotes)
            {
                postUpvotes = PostScore + 1;


            }
            public void upvote(ref int postDownvotes)
            {
                postDownvotes = PostScore - 1;

            }
        }
    }
}

