﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GroceryListManager.Models;

namespace GroceryListManager.Pages.Items
{
    public class IndexModel : PageModel
    {
        private readonly GroceryListManager.Models.GroceryListManagerContext _context;

        public IndexModel(GroceryListManager.Models.GroceryListManagerContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }

        public async Task OnGetAsync()
        {
            Item = await _context.Item.ToListAsync();
        }
    }
}
