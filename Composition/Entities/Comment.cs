namespace Composition.Entities
{
    internal class Comment
    {
        public string Text { get; set; }

        /*Contrutor vazio*/
        public Comment() 
        {
        }

        /*Construtor com os argumentos*/
        public Comment(string text)
        {
            Text = text;
        }

    }
}
