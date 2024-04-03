using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UniversityDepartmentApp.Data;
using UniversityDepartmentApp.Models;

namespace UniversityDepartmentApp.Pages.Universities
{
    public class IndexModel : PageModel
    {
        private readonly UniversityDepartmentApp.Data.UniContext _context;

        public IndexModel(UniversityDepartmentApp.Data.UniContext context)
        {
            _context = context;
        }

        public IList<University> University { get;set; } = default!;

        public async Task OnGetAsync()
        {
            University = await _context.Universities.ToListAsync();
        }
    }
}
