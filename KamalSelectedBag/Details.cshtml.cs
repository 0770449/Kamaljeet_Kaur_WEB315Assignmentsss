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
    public class DetailsModel : PageModel
    {
        private readonly KamalSelectedBagContext _context;

        public DetailsModel(KamalSelectedBagContext context)
        {
            _context = context;
        }

        public Bag Bag { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bag = await _context.Bag.FirstOrDefaultAsync(m => m.ID == id);

            if (Bag == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
