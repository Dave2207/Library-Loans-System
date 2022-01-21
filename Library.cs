namespace Biblio
{
    public class Library
    {
        public List<Paper> papers_list { get; set; }
        public List<Client> clients_list { get; set; }
        public List<Loan> loans_list { get; set; }
        public int idLoanGenerator { get; set; }

        public Library()
        {
            papers_list = new List<Paper>();
            clients_list = new List<Client>();
            loans_list = new List<Loan>();
            idLoanGenerator = 1;
        }

        public void addPaper(Paper p)
        {
            papers_list.Add(p);
        }

        public void addClient(Client c){
            clients_list.Add(c);
        }

        public string findTitleById(string idPaper)
        {
            string title = "";
            bool found = false;
            int i = 0;
            while (!found && i < papers_list.Count)
            {
                if (papers_list[i].id.Equals(idPaper))
                {
                    title = papers_list[i].title;
                    found = true;
                }
                i++;
            }

            return title;
        }

        public int docsQtyBySubject(string subj)
        {
            int qty = 0;
            foreach (Paper aux in papers_list)
            {
                if (aux.subject.Equals(subj))
                {
                    qty += aux.qtyCopies;
                }
            }
            return qty;
        }

        public bool makeLoan(string idClient, string idPaper, DateTime returnDate)
        {
            bool done = false;
            Client? client = findClientByID(idClient);
            Paper? paper = findPaperByID(idPaper);

            if (client != null && paper != null)
            {
                if (paper.status == true && client.qtyLoan < 5)
                {
                    Loan loan = new Loan("P-" + idLoanGenerator, returnDate, idClient, paper);
                    loans_list.Add(loan);
                    client.addLoan(loan);
                    paper.updateCopies(true);
                    idLoanGenerator++;
                    done = true;
                }
            }
            return done;
        }

        public Client findClientByID(string idClient)
        {
            Client? aux = null;
            bool found = false;
            int i = 0;
            while (!found && i < clients_list.Count)
            {
                if (clients_list[i].id.Equals(idClient))
                {
                    aux = clients_list[i];
                    found = true;
                }
                i++;
            }
            return aux;
        }

        private Paper findPaperByID(string idPaper)
        {
            Paper? aux = null;
            bool found = false;
            int i = 0;

            while (!found && i < papers_list.Count)
            {
                if (papers_list[i].id.Equals(idPaper))
                {
                    aux = papers_list[i];
                    found = true;
                }
                i++;
            }
            return aux;
        }
    }
}

