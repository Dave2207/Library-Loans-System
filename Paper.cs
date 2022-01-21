namespace Biblio
{
    public class Paper
    {
        string id { get; set; }
        string title { get; set; }
        int qtyCopies { get; set; }
        bool status { get; set; }
        string subject { get; set; }

        public Paper(string id, string title, int qtyCopies, string subject)
        {
            this.id = id;
            this.title = title;
            this.qtyCopies = qtyCopies;
            this.status = true;
            this.subject = subject;
        }

        public void updateCopies(bool reason)
        {
            if (reason)
            {
                qtyCopies--;
                if (qtyCopies == 0)
                {
                    status = false;
                }
            }
            else
            {
                qtyCopies++;
                if (qtyCopies > 0)
                {
                    status = true;
                }
            }
        }
    }
}