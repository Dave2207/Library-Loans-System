namespace Biblio
{
    public class Article : Paper
    {
        private string author { get; set; }
        private string referee { get; set; }

        public Article(string id, string title, int qtyCopies, string subject, string author, string referee)
        : base(id, title, qtyCopies, subject)
        {
            this.author = author;
            this.referee = referee;
        }
    }
}