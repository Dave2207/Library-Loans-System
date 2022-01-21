namespace Biblio
{
    public class Paper
    {
        public string id { get; set; }
        public string title { get; set; }
        public int qtyCopies { get; set; }
        public bool status { get; set; }
        public string subject { get; set; }

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