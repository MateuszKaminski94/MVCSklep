using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MateuszowSKYSklep.Models;

namespace MateuszowSKYSklep.ViewModels
{
    public class DetailsViewModel
    {
        public Game Games { get; set; }

        public IEnumerable<string> Links { get; set; }
    }
}