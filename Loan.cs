namespace Biblio
{
    public class Loan
    {
        private int id { get; set; }
        private DateTime start_date { get; set; }
        private DateTime return_date { get; set; }
        private string clientID { get; set; }
        private Paper paper { get; set; }
        private bool status { get; set; }
        private bool prorogated { get; set; }

        public Loan(int id, DateTime return_date, string clientID, Paper paper)
        {
            this.id = id;
            this.start_date = new DateTime();
            this.return_date = return_date;
            this.clientID = clientID;
            this.paper = paper;
            this.status = true;
            this.prorogated = false;
        }
    }
}