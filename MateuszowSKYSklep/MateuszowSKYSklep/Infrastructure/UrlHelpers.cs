﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MateuszowSKYSklep.Infrastructure
{
    public static class UrlHelpers
    {
        public static string GenreIconPath(this UrlHelper helper, string genreIconFilename)
        {
            var genreIconFolder = AppConfig.GenreIconsFolderRelative;
            var path = Path.Combine(genreIconFolder, genreIconFilename);
            var absolutePath = helper.Content(path);
            return absolutePath;
        }

        public static string GameScreenPath(this UrlHelper helper, string gameScreenname)
        {
            var gameScreenFolder = AppConfig.GameScreensFolderRelative;
            var path = Path.Combine(gameScreenFolder, gameScreenname);
            var absolutePath = helper.Content(path);
            return absolutePath;
        }
    }
}