namespace Biblio{
    public class Magazine : Paper
    {
        private int year {get; set;}
        private string edition {get; set;}
        public Magazine(string id, string title, int qtyCopies, string subject, int year, string edition) 
        : base(id, title, qtyCopies, subject)
        {
            this.year = year;
            this.edition = edition;
        }
    }
}