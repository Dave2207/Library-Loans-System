namespace Biblio
{
    public class Book : Paper
    {
        string editorial { get; set; }
        string author { get; set; }
        public Book(string id, string title, int qtyCopies, string subject, string editorial, string author) 
        : base(id, title, qtyCopies, subject)
        {
            this.editorial = editorial;
            this.author = author;
        }
    }
}