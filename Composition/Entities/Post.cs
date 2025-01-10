using System;
using System.Collections.Generic;
using System.Text;

namespace Composition.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        /*Construtor vazio*/
        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        /*As Operações "Add" e "Remove" são padrão em Composition e Enum para as Entidades*/
        public void AddComment(Comment comment) 
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment) 
        {
            Comments.Remove(comment);
        }

        /*Declarar um Objeto "StringBuilder" e instanciar*/
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.Append(Moment.ToString("dd/MM/yyyy HH:mm:ss "));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
