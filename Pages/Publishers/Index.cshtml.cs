﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_Bianca_Lab2.Data;
using Pop_Bianca_Lab2.Models;

namespace Pop_Bianca_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Pop_Bianca_Lab2.Data.Pop_Bianca_Lab2Context _context;

        public IndexModel(Pop_Bianca_Lab2.Data.Pop_Bianca_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
