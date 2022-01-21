using System;
namespace Biblio
{
    public class Library
    {
        List<Paper> papers_list {get; set;}
        List<Client> clients_list {get; set;}
        List<Loan> loans_list {get; set;}
        
        public Library()
        {
            papers_list = new List<Paper>();
            clients_list = new List<Client>();
            loans_list = new List<Loan>();
        }

        public void addPaper(Paper p){
            papers_list.Add(p);
        }

        public string findTitleById(string idPaper){
            string title = "";
            bool found = false;
            int i = 0;
            while (!found && i<papers_list.Count)
            {
                
            }

            return title;
        }
    }
}

