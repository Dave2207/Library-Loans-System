namespace Biblio{
    public class Magazine : Paper
    {
        int year {get; set;}
        string edition {get; set;}
        public Magazine(string id, string title, int qtyCopies, string subject, int year, string edition) 
        : base(id, title, qtyCopies, subject)
        {
            this.year = year;
            this.edition = edition;
        }
    }
}