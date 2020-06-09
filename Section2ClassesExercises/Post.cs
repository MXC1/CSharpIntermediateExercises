using System.Runtime.CompilerServices;
using System;
namespace Section2ClassesExercises
{
    class Post
    {
        private readonly string title;
        private readonly string description;
        private readonly DateTime posted;
        private int votes = 0;


        public Post(string title, string description)
        {
            this.title = title;
            this.description = description;
            this.posted = DateTime.Now;
        }

        public int upVote()
        {
            return ++votes;
        }

        public int downVote()
        {
            return --votes;
        }

        public int getVotes()
        {
            return votes;
        }
    }
}
