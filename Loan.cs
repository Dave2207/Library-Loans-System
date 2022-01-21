namespace Biblio
{
    public class Loan
    {
        int id { get; set; }
        DateTime start_date { get; set; }
        DateTime return_date { get; set; }
        string clientID { get; set; }
        Paper paper { get; set; }
        bool status { get; set; }
        bool prorogated { get; set; }

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