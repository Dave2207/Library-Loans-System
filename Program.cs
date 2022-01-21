namespace Biblio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Library lib = new Library();
            Client david = new Client("1234", "David Vasquez", "Vicente Estrella #73");
            lib.addClient(david);
            Book libro1 = new Book("11", "El nombre del viento", 50, "Fiction", "Shueisha", "Boichi");
            Magazine mag1 = new Magazine("22", "Shonen Jump", 45, "Manga", 2011, "Limited #5");
            lib.addPaper(libro1);
            lib.addPaper(mag1);

            Console.WriteLine(lib.papers_list[0].title);
            Console.WriteLine(lib.papers_list[1].title);

            lib.makeLoan("1234", "11", DateTime.Now);
            Console.WriteLine(lib.papers_list[0].qtyCopies);
        }
    }
}