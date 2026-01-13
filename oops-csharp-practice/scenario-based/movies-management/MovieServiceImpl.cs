using System;
using System.Collections.Generic;

public class MovieServiceImpl : IMovieService
{
    private List<Movie> movies = new List<Movie>();

    // Add movie
    public void AddMovie(string title, string time)
    {
        Movie existingMovie = FindMovieByTitle(title);

        if (existingMovie != null)
        {
            existingMovie.AddShowTime(time);
        }
        else
        {
            Movie movie = new Movie(title);
            movie.AddShowTime(time);
            movies.Add(movie);
        }

        Console.WriteLine("Movie added successfully.");
    }

    // Search movie using Contains()
    public void SearchMovie(string keyword)
    {
        bool found = false;

        foreach (Movie movie in movies)
        {
            if (movie.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < movie.ShowTimeCount; i++)
                {
                    Console.WriteLine($"{movie.Title} - Show Time: {movie.ShowTimes[i]}");
                }
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No matching movie found.");
        }
    }

    // Display all movies
    public void DisplayAllMovies()
    {
        if (movies.Count == 0)
        {
            Console.WriteLine("No movies available.");
            return;
        }

        foreach (Movie movie in movies)
        {
            for (int i = 0; i < movie.ShowTimeCount; i++)
            {
                Console.WriteLine($"{movie.Title} - Show Time: {movie.ShowTimes[i]}");
            }
        }
    }

    // Helper method
    private Movie FindMovieByTitle(string title)
    {
        foreach (Movie movie in movies)
        {
            if (movie.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                return movie;
            }
        }
        return null;
    }
}
