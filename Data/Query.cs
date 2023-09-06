using superpowergraphql.Models;
using HotChocolate.AspNetCore;
using HotChocolate.Types;
using HotChocolate.Data;
using System;

namespace superpowergraphql.Data
{
    public class Query
    {

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Superhero> getSuperheroes([Service] ApplicationDbContext _appDbContext) => _appDbContext.Superheroes;
        
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Movie> getMovies([Service] ApplicationDbContext _appDbContext) => _appDbContext.Movies;

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Superpower> getSuperpowers([Service] ApplicationDbContext _appDbContext) => _appDbContext.Superpowers;
        
    }
}