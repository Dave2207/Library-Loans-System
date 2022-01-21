namespace Biblio
{
    public class Loan
    {
        public string id { get; set; }
        public DateTime start_date { get; set; }
        public DateTime return_date { get; set; }
        public string clientID { get; set; }
        public Paper paper { get; set; }
        public bool status { get; set; }
        public bool prorogated { get; set; }

        public Loan(string id, DateTime return_date, string clientID, Paper paper)
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