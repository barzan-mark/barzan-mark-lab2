using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Barzan_Mark_Lab2.Data;

namespace Barzan_Mark_Lab2.Models
{
    public class IndexModel : PageModel
    {
        private readonly Barzan_Mark_Lab2.Data.Barzan_Mark_Lab2Context _context;

        public IndexModel(Barzan_Mark_Lab2.Data.Barzan_Mark_Lab2Context context)
        {
            _context = context;
        }

        public IList<Authors> Authors { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Authors = await _context.Authors.ToListAsync();
        }
    }
}
