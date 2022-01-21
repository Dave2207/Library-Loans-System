namespace Biblio
{
    public class Client
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public List<Loan> loans { get; set; }
        public int qtyLoan { get; set; }

        public Client(string id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.loans = new List<Loan>();
            this.qtyLoan = 0;
        }

        public void addLoan(Loan lo)
        {
            loans.Add(lo);
            qtyLoan++;
        }
    }

}