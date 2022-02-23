using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KamalSelectedBag.Models;

namespace KamalSelectedBag
{
    public class IndexModel : PageModel
    {
        private readonly KamalSelectedBagContext _context;

        public IndexModel(KamalSelectedBagContext context)
        {
            _context = context;
        }

        public IList<Bag> Bag { get;set; }

        public async Task OnGetAsync()
        {
            Bag = await _context.Bag.ToListAsync();
        }
    }
}
