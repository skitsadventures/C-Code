using System;

class Program
{

    struct Movie
    {

        public string MovieTitle;
        public int YearProduced;
    }
        static void Main(string[] args)
        {

            int total = 3;
            Movie[] movie = new Movie[total];
            Console.WriteLine("Please enter a Movie Title: ");
            Console.WriteLine("Please enter the year the movie was produced: ");
            for (int i = 0; i < total; i++)
            {

                movie[i] = new Movie()
                {
                    MovieTitle = Console.ReadLine(),
                    YearProduced = int.Parse(Console.ReadLine())
                };
            Console.WriteLine("Another please: ");
            }
            for (int i = 0; i < total - 1; i++)
            {

                for(int j = 0; j < total; j++)
                {

                    if (movie[j].YearProduced > movie[i].YearProduced)
                    {
                        var aux = movie[i];
                        movie[i] = movie[j];
                        movie[j] = aux;                        
                    }
                }
            }
        for(int i = 0; i < total; i++)
        {
            Console.WriteLine(" Movie Title: " + movie[i].MovieTitle + " | year of production: " + movie[i].YearProduced); 
        }
        }
}