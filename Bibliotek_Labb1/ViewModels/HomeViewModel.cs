﻿using Bibliotek_Labb1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Book> BookInventory { get; set; }
    }
}
