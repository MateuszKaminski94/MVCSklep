using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MateuszowSKYSklep.Models;

namespace MateuszowSKYSklep.ViewModels
{
    public class ListViewModel
    {
        public IEnumerable<Game> Games { get; set; }
    }
}