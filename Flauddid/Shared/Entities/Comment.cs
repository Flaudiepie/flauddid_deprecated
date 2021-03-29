using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Domain
{
    public class Comment
    {
        public string ID { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public int Votes { get; set; }
        public ICollection<Comment> Reply { get; set; } 
        public DateTime? Created { get; set; }
        public DateTime? Edited { get; set; }

        public Comment(string ID, string content, string author, int votes, DateTime? created, DateTime? edited, ICollection<Comment> reply)
        {
            this.ID = ID;
            Content = content;
            Author = author;
            Votes = votes;
            Reply = reply;
            Created = created;
            Edited = edited;
        }
        
        public Comment(string ID, string content, string author, int votes, DateTime? created, DateTime? edited)
        {
            this.ID = ID;
            Content = content;
            Author = author;
            Votes = votes;
            Created = created;
            Edited = edited;
        }

        public Comment()
        {

        }
    }
}
