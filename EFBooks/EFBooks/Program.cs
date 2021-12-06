using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBooks
{
    class Program
    {
        static void Main(string[] args)
        {

            EFBooks.BooksEntities db = new EFBooks.BooksEntities();

            ShowAuthors("All authors", db.Authors);

            ShowAuthors("Authors sorted by first name", db.Authors.OrderBy(a => a.FirstName));

            ShowAuthors("Authors sorted by first name", db.Authors
                .OrderBy(a => a.LastName)
                .ThenBy(a => a.FirstName));


            //db.Authors.Add(new Author() { FirstName = "Efoe", LastName = "Gnassia" });
            //db.Authors.Remove(db.Authors
            //    .Where(a => a.LastName == "Gnassia")
            //    .FirstOrDefault());

            //db.SaveChanges();

            ShowAuthors("All authors", db.Authors);



            ShowTitles("All tittles", db.Titles);

            ShowTitles("Tittles with 2016 copyright", db.Titles.Where(t => t.Copyright == "2016"));

            ShowTitles("All tittles end with 'How to program' ", db.Titles.Where(t => t.Title1.EndsWith("How to program")));

            Console.ReadKey();


            void ShowAuthors(string title, IEnumerable<Author> authors)
            {
                Console.WriteLine("\n" + title);
                Console.WriteLine("ID  First Name     Last Name");
                Console.WriteLine("--- -------------- ---------------");
                foreach (Author a in authors)
                {
                    //Console.WriteLine($"{a.AuthorID,-3} {a.FirstName,-15}{a.LastName,-15}");

                    Console.WriteLine($"{a.AuthorID,-3} {a.FullName,-30}");
                }
            }

            void ShowTitles(string title, IEnumerable<Title> titles)
            {
                Console.WriteLine("\n" + title);
                Console.WriteLine($"{"ISBN",-11} {"Title",-60} {"Edition",7} {"Copyright",10}");
                Console.WriteLine($"{"----",-11} {"-----",-60} {"-------",7} {"---------",10}");
                foreach (Title t in titles)
                {
                    Console.WriteLine($"{t.ISBN,-11} {t.Title1,-60} {t.EditionNumber,7} {t.Copyright,10}");
                }
            }
        }
    }

    public partial class Author
    {
        public string FullName { get => $"{FirstName} {LastName}"; }
    }
}
