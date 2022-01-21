namespace Biblio{
    public class Magazine : Paper
    {
        public int year {get; set;}
        public string edition {get; set;}
        public Magazine(string id, string title, int qtyCopies, string subject, int year, string edition) 
        : base(id, title, qtyCopies, subject)
        {
            this.year = year;
            this.edition = edition;
        }
    }
}