using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glimpse.Mvc.AlternateType;

namespace MateuszowSKYSklep.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public int GenreId { get; set; }
        public string GameTitle { get; set; }
        public string DeveloperName { get; set; }
        public DateTime DateAdded { get; set; }
        public string MainImageFilename { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsPreOrder { get; set; }
        public bool IsHidden { get; set; }

        public virtual Genre Genre { get; set; }
    }
}