namespace Biblio
{
    public class Paper
    {
        protected string id { get; set; }
        protected string title { get; set; }
        protected int qtyCopies { get; set; }
        protected bool status { get; set; }
        protected string subject { get; set; }

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