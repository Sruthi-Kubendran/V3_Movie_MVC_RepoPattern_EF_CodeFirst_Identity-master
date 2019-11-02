using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using V3_Movie_MVC_RepoPattern_EF_CodeFirst_Identity.Models;
using V3_Movie_MVC_RepoPattern_EF_CodeFirst_Identity.ViewModels;

namespace V3_Movie_MVC_RepoPattern_EF_CodeFirst_Identity.Data
{
    public interface IRepository
    {
        IEnumerable<Movie> GetMovies();
        bool AddMovie(MovieViewModel viewModel);
        bool EditMovie(MovieViewModel viewModel);
        bool DeleteMovie(int id);
        Movie GetMovieById(int movieId);
        IEnumerable<Movie> GetMoviesByGenre(Genre genre);
        IEnumerable<Movie> GetMoviesByActor(int actorId);
        IEnumerable<Actor> GetActors();
        bool AddActor(Actor actor);
        bool EditActor(Actor actor);
        bool DeleteActor(Actor actor);
        Actor GetActorById(int ActorId);
        IEnumerable<Actor> GetActorsByGender(Gender gender);
        IEnumerable<Actor> GetActorsByMovie(int movieId);
        
    }
}
