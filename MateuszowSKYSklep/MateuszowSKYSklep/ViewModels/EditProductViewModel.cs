﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MateuszowSKYSklep.Models;

namespace MateuszowSKYSklep.ViewModels
{
    public class EditProductViewModel
    {
        public Game Game { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public bool? ConfirmSuccess { get; set; }
    }
}