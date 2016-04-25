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
        public int ImagesCount { get; set; }
        public  virtual List<string> ImageFilenames { get; set; }
        //public virtual List<string> ImageFilename1 { get; set; }
        //public string ImageFilename2 { get; set; }
        //public string ImageFilename3 { get; set; }
        //public string ImageFilename4 { get; set; }
        //public string ImageFilename5 { get; set; }
        //public string ImageFilename6 { get; set; }
        //public string ImageFilename7 { get; set; }
        //public string ImageFilename8 { get; set; }
        //public string ImageFilename9 { get; set; }
        //public string ImageFilename10 { get; set; }

        public virtual Genre Genre { get; set; }
    }
}