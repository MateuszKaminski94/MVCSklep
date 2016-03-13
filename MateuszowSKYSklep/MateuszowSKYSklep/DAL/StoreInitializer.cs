using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using MateuszowSKYSklep.Models;

namespace MateuszowSKYSklep.DAL
{
    public class StoreInitializer : DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            SeedStoreData(context);

            base.Seed(context);
        }

        private void SeedStoreData(StoreContext context)
        {
            var genres = new List<Genre>
            {
                new Genre() {GenreId = 1, Name = "Akcji",IconFilename = "akcji.png"},
                new Genre() {GenreId = 2, Name = "Fabularne",IconFilename = "fabularne.png"},
                new Genre() {GenreId = 3, Name = "Indie",IconFilename = "indie.png"},
                new Genre() {GenreId = 4, Name = "Przygodowe",IconFilename = "przygodowe.png"},
                new Genre() {GenreId = 5, Name = "Sportowe",IconFilename = "sportowe.png"},
                new Genre() {GenreId = 6, Name = "Strategie",IconFilename = "strategie.png"},
                new Genre() {GenreId = 7, Name = "Strzelaniny",IconFilename = "strzelaniny.png"},
                new Genre() {GenreId = 8, Name = "Symulacje",IconFilename = "symulacje.png"}
            };

            genres.ForEach(g => context.Genres.Add(g));
            context.SaveChanges();

            var games = new List<Game>
            {
                new Game() {GameId = 1, DeveloperName = "Remedy Entertainment", GameTitle = "Alan Wake" , Price=35.78M, MainImageFilename = "1.png", IsPreOrder = true, DateAdded = new DateTime(2012, 01, 16), GenreId = 1},
                new Game() {GameId = 2, DeveloperName = "Ubisoft", GameTitle = "Rayman Forever" , Price=5.39M, MainImageFilename = "2.png", IsPreOrder = false, DateAdded = new DateTime(1999, 05, 31), GenreId = 1},
                new Game() {GameId = 3, DeveloperName = "Re-Logic", GameTitle = "Terraria" , Price=8.99M, MainImageFilename = "3.png", IsPreOrder = true, DateAdded = new DateTime(2011, 05, 16), GenreId = 1},
                new Game() {GameId = 4, DeveloperName = "Starbreeze Studios", GameTitle = "Encalve" , Price=5.39M, MainImageFilename = "4.png", IsPreOrder = false, DateAdded = new DateTime(2002, 07, 19), GenreId = 1},
                new Game() {GameId = 5, DeveloperName = "Red Barrels", GameTitle = "Outlast" , Price=17.89M, MainImageFilename = "5.png", IsPreOrder = true, DateAdded = new DateTime(2013, 09, 4), GenreId = 1},
                new Game() {GameId = 6, DeveloperName = "Piranha Bytes", GameTitle = "Risen" , Price=8.99M, MainImageFilename = "6.png", IsPreOrder = false, DateAdded = new DateTime(2009, 09, 2), GenreId = 1},
                new Game() {GameId = 7, DeveloperName = "CD PROJEKT RED", GameTitle = "Witcher 3" , Price=39.99M, MainImageFilename = "7.png", IsPreOrder = true, DateAdded = new DateTime(2015, 05, 19), GenreId = 2},
                new Game() {GameId = 8, DeveloperName = "Piranha Bytes", GameTitle = "Gothic II" , Price=8.99M, MainImageFilename = "8.png", IsPreOrder = false, DateAdded = new DateTime(2005, 11, 29), GenreId = 2},
                new Game() {GameId = 9, DeveloperName = "ASCARON Entertainment", GameTitle = "Sacred" , Price=22.38M, MainImageFilename = "9.png", IsPreOrder = false, DateAdded = new DateTime(2004, 09, 22), GenreId = 2}
            };

            games.ForEach(h => context.Games.Add(h));
            context.SaveChanges();
        }
    }
}