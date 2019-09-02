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
        public DateTime DatePremiere { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string Gpu { get; set; }
        public string Hdd { get; set; }
        public string Os { get; set; }
        public decimal Price { get; set; }
        public bool IsPreOrder { get; set; }
        public bool IsHidden { get; set; }
        public string ImageFilename { get; set; }

        public virtual Genre Genre { get; set; }
    }
}