using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MateuszowSKYSklep.Infrastructure
{
    public class AppConfig
    {
        private static string _genreIconsFolderRelative = ConfigurationManager.AppSettings["GenreIconsFolder"];

        public static string GenreIconsFolderRelative
        {
            get
            {
                return _genreIconsFolderRelative;
            }
        }

        private static string _gameImagesFolderRelative = ConfigurationManager.AppSettings["GameImagesFolder"];

        public static string GameImagesFolderRelative
        {
            get
            {
                return _gameImagesFolderRelative;
            }
        }
    }
}