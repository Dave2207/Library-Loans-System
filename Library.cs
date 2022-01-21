namespace Biblio
{
    public class Library
    {
        private List<Paper> papers_list {get; set;}
        private List<Client> clients_list {get; set;}
        private List<Loan> loans_list {get; set;}
        
        public Library()
        {
            papers_list = new List<Paper>();
            clients_list = new List<Client>();
            loans_list = new List<Loan>();
        }

    }
}

