using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301264350_shields__Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 02 - Lab 04");

            // Invokes methods
            Question2_1();
            Question2_2();
            Question2_3();

            //1.Get a list of all the titles and the authors who wrote them. Sort the results by title. [2 marks]
            void Question2_1()
            {
                Console.WriteLine("Question2_1:");
                using (var context = new BooksEntities())
                {
                    var titlesWithAuthors = context.Titles
                        .OrderBy(t => t.Title1)
                        .Select(t => new
                        {
                            Title = t.Title1,
                            Authors = t.Authors.Select(a => a.FirstName + " " + a.LastName)
                        })
                        .ToList();

                    foreach (var titleWithAuthors in titlesWithAuthors)
                    {
                        Console.WriteLine($"Title: {titleWithAuthors.Title}");
                        foreach (var author in titleWithAuthors.Authors)
                        {
                            Console.WriteLine($" - Author: {author}");
                        }
                        Console.WriteLine();
                    }
                }
            }

            //2.Get a list of all the titles and the authors who wrote them. Sort the results by title.  Each title sort the authors alphabetically by last name, then first name[4 marks]
            void Question2_2()
            {
                Console.WriteLine("Question2_2:");
                using (var context = new BooksEntities())
                {
                    var titlesWithAuthors = context.Titles
                        .OrderBy(t => t.Title1)
                        .Select(t => new
                        {
                            Title = t.Title1,
                            Authors = t.Authors.OrderBy(a => a.LastName).ThenBy(a => a.FirstName)
                        })
                        .ToList();

                    foreach (var titleWithAuthors in titlesWithAuthors)
                    {
                        Console.WriteLine($"Title: {titleWithAuthors.Title}");
                        foreach (var author in titleWithAuthors.Authors)
                        {
                            Console.WriteLine($" - Author: {author.FirstName} {author.LastName}");
                        }
                        Console.WriteLine();
                    }
                }
            }

            //3.Get a list of all the authors grouped by title, sorted by title; for a given title sort the author names alphabetically by last name then first name.[4 marks]
            void Question2_3()
            {
                Console.WriteLine("Question2_3:");
                using (var context = new BooksEntities())
                {
                    var authorsGroupedByTitle = context.Titles
                        .OrderBy(t => t.Title1)
                        .Select(t => new
                        {
                            Title = t.Title1,
                            Authors = t.Authors.OrderBy(a => a.LastName).ThenBy(a => a.FirstName)
                        })
                        .ToList();

                    foreach (var titleWithAuthors in authorsGroupedByTitle)
                    {
                        Console.WriteLine($"Title: {titleWithAuthors.Title}");
                        foreach (var author in titleWithAuthors.Authors)
                        {
                            Console.WriteLine($" - Author: {author.FirstName} {author.LastName}");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
