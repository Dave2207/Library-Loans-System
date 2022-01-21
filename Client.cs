namespace Biblio
{
    public class Client
    {
        string id { get; set; }
        string name { get; set; }
        string address { get; set; }
        List<Loan> loans { get; set; }
        int qtyLoan { get; set; }

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