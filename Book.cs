namespace Biblio
{
    public class Book : Paper
    {
        private string editorial { get; set; }
        private string author { get; set; }
        public Book(string id, string title, int qtyCopies, string subject, string editorial, string author) 
        : base(id, title, qtyCopies, subject)
        {
            this.editorial = editorial;
            this.author = author;
        }
    }
}