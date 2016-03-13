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
        }
    }
}