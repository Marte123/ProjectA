using ProjectA.Models.Entertainment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectA.Data
{
    public class DataClass
    {
        public static System.Collections.Generic.List<Movie> getMovies()

        {
            List<Movie> movies = new List<Movie>()
{
    new Movie(){
    MovieName="Lion",
    Genre=" Biography,Drama",
    State="USA, UK, Australia",
    Director="Garth Davis",
    Duration= 118,
    Release= 2016,
},
    new Movie() {
    MovieName="Jack Reacher",
    Genre="Action,Crime,Mystery",
    State="USA",
    Director=" Christopher McQuarrie",
    Duration= 130,
    Release= 2012,
},
    new Movie() {
    MovieName="Keeping Up with the Joneses",
    Genre="Action,Comedy",
    State="USA",
    Director="Greg Mottola",
    Duration= 105,
    Release= 2016,
},
    new Movie() {
    MovieName="Geostorm",
    Genre="Action,Sci-fi,Thriller",
    State="USA",
    Director=" Dean Devlin",
    Duration= 109,
    Release= 2017,
},
    new Movie() {
    MovieName="Transformers",
    Genre="Action,Sci-fi,Adventure",
    State="USA",
    Director="Michael Bay",
    Duration= 149,
    Release= 2017,
},
    new Movie() {
    MovieName="King Arthur",
    Genre=" Action, Adventure, Drama ",
    State="USA",
    Director="Guy Ritchie",
    Duration= 126,
    Release= 2017,
},
    new Movie() {
    MovieName="Pirates of the Caribbean",
    Genre=" Action, Adventure, Drama ",
    State="USA",
    Director=" Joachim Rønning, Espen Sandberg",
    Duration= 120,
    Release= 2017,
},
    new Movie() {
    MovieName="Justice League",
    Genre=" Action, Adventure, Fantasy",
    State="USA",
    Director=" Zack Snyder",
    Duration= 120,
    Release= 2017,
},
    new Movie() {
    MovieName="The House of the Spirits",
    Genre=" Drama, Romance",
    State="USA",
    Director=" Bille August",
    Duration= 140,
    Release= 1993,
},
    new Movie() {
    MovieName="Seven Pounds",
    Genre=" Drama, Romance",
    State="USA",
    Director=" Gabriele Muccino",
    Duration= 123,
    Release= 2008,
},
    new Movie() {
    MovieName="No Escape",
    Genre=" Action, Thriller",
    State="USA",
    Director="John Erick Dowdle",
    Duration= 103,
    Release= 2015,
},
    new Movie() {
    MovieName="Death Becomes Her",
    Genre="  Comedy, Fantasy, Horror ",
    State="USA",
    Director="Robert Zemeckis",
    Duration= 104,
    Release= 1992,
},

};

            return movies;
        }
        public static List<Actor> getActors(MediaContext context)
        {
            List<Actor> actors = new List<Actor>()
{
    new Actor {
    FirstName="Dev",
    LastName="Patel",
    MovieName= context.Movies.Find("Lion").MovieName,
    PersonalDetails="Dev Patel was born on April 23,1990 in Harrow, London.",
},


    new Actor {
    FirstName="Tom",
    LastName="Cruise",
    MovieName= context.Movies.Find("Jack Reacher").MovieName,
    PersonalDetails="Tom was born on July 3, 1962 and he is the only son (among four children) of nomadic parents, Mary Lee (Pfeiffer), a special education teacher, and Thomas Cruise Mapother III, an electrical engineer.",
},

    new Actor {
    FirstName="Isla",
    LastName="Fisher",
    MovieName= context.Movies.Find("Keeping Up with the Joneses").MovieName,
    PersonalDetails="Isla Lang Fisher was born on February 3, 1976 in Muscat, Oman.",
},


    new Actor {
    FirstName="Gerard",
    LastName=" Butler",
    MovieName= context.Movies.Find("Geostorm").MovieName,
    PersonalDetails="Gerard James Butler was born in Paisley, Scotland on November 13, 1969.",
},

    new Actor {
    FirstName="Josh",
    LastName=" Duhamel",
    MovieName= context.Movies.Find("Transformers").MovieName,
    PersonalDetails="Joshua David Duhamel was born in Minot, North Dakota, on November 14, 1972.",
},
    new Actor {
    FirstName="Charlie ",
    LastName="Hunnam",
    MovieName= context.Movies.Find("King Arthur").MovieName,
    PersonalDetails="Charles Matthew Hunnam was born in Newcastle, England on April 10, 1980.",
},
    new Actor {
    FirstName="Johnny",
    LastName="Depp",
    MovieName= context.Movies.Find("Pirates of the Caribbean").MovieName,
    PersonalDetails="Johnny Depp was born John Christopher Depp II in Owensboro, Kentucky, on June 9, 1963. ",
},
    new Actor {
    FirstName="Ben",
    LastName="Affleck",
    MovieName= context.Movies.Find("Justice League").MovieName,
    PersonalDetails="American actor and filmmaker Benjamin Géza Affleck-Boldt was born on August 15, 1972 in Berkeley, California.",
},
    new Actor {
    FirstName="Antonio",
    LastName="Banderas",
    MovieName= context.Movies.Find("The House of the Spirits").MovieName,
    PersonalDetails=" He was born JosÃfÂ© Antonio DomÃfÂ­nguez Banderas on August 10, 1960, in MÃfÂ¡laga, Andalusia, Spain.",
},
    new Actor {
    FirstName="Will",
    LastName="Smith",
    MovieName= context.Movies.Find("Seven pounds").MovieName,
    PersonalDetails="Willard Carroll Will Smith, Jr. (born September 25, 1968) is an American actor, comedian, producer, rapper, and songwriter.",
},
    new Actor {
    FirstName="Pierce",
    LastName="Brosnan",
    MovieName= context.Movies.Find("No escape").MovieName,
    PersonalDetails="Pierce Brendan Brosnan was born on May 16, 1953 in Drogheda, County Louth, Ireland. ",
},

    new Actor {
    FirstName="Meryl ",
    LastName="Streep",
    MovieName= context.Movies.Find("Death becomes her").MovieName,
    PersonalDetails=" Meryl was born Mary Louise Streep on June 22,1949 in Summit, New Jersey."
},
    };
            return actors;
        }
    }
}

