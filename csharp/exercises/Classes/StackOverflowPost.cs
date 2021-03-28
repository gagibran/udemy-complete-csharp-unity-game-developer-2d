using System;
using System.Collections.Generic;

namespace Classes
{
    /// <summary>
    /// Design a class called Post. This class models a StackOverflow post. It should have properties
    /// for title, description and the date/time it was created.We should be able to up-vote or down-vote
    /// a post.We should also be able to see the current vote value.In the main method, create a post,
    /// up-vote and down-vote it a few times and then display the current vote value.
    /// <para />
    /// In this exercise, you will learn that a StackOverflow post should provide methods for up-voting
    /// and down-voting.you should not give the ability to set the vote property from the outside,
    /// because otherwise, you may accidentally change the votes of a class to 0 or to a random
    /// number.and this is how we create bugs in our programs. the class should always protect its
    /// state and hide its implementation detail.
    /// </summary>
    /// <remarks>
    /// Educational tip: The aim of this exercise is to help you understand that classes should
    /// encapsulate data AND behavior around that data.Many developers(even those with years of
    /// experience) tend to create classes that are purely data containers, and other classes that are
    /// purely behavior(methods) providers.This is not object-oriented programming.This is
    /// procedural programming. Such programs are very fragile.Making a change breaks many parts
    /// of the code.
    /// </remarks>
    public class StackOverflowPost
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Votes { get; private set; }
        public DateTime CreationTime { get; }
        private List<StackOverflowPost> _comments;

        public StackOverflowPost(string title)
        {
            _comments = new List<StackOverflowPost>();
            CreationTime = DateTime.Now;
            Title = title;
        }

        public StackOverflowPost(string title, string description) : this(title)
        {
            Description = description;
        }

        public void GetComments()
        {
            foreach (var comment in _comments)
            {
                Console.WriteLine($"The comment \"{comment.Title}\" has {comment.Votes} votes.");
            }
        }

        public void UpVote()
        {
            Votes += 1;
        }

        public void DownVote()
        {
            Votes -= 1;
        }

        public void AddComment(StackOverflowPost comment)
        {
            _comments.Add(comment); // A comment is nothing but a post inside a post.
        }
    }
}
