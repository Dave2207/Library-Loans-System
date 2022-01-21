namespace Biblio
{
    public class Client
    {
        private string id { get; set; }
        private string name { get; set; }
        private string address { get; set; }
        private List<Loan> loans { get; set; }
        private int qtyLoan { get; set; }

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