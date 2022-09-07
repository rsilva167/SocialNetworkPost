using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostInSM.Entities
{
    internal class Post
    {
        public DateTime Time { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {

        }

        public Post(DateTime time, string title, string content, int likes)
        {
            Time = time;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComments (Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComments (Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Time.ToString("dd/mm/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Coments: ");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
}
