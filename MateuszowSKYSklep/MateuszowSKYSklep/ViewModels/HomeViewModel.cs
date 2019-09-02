using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MateuszowSKYSklep.Models;

namespace MateuszowSKYSklep.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Game> PreOrders { get; set; }

        public IEnumerable<Game> Randoms { get; set; }
    }
}