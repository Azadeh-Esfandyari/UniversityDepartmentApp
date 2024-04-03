using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UniversityDepartmentApp.Data;
using UniversityDepartmentApp.Models;

namespace UniversityDepartmentApp.Pages.Departments
{
    public class IndexModel : PageModel
    {
        private readonly UniversityDepartmentApp.Data.UniContext _context;

        public IndexModel(UniversityDepartmentApp.Data.UniContext context)
        {
            _context = context;
        }

        public IList<Department> Department { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Department = await _context.Departments
                .Include(d => d.University).ToListAsync();
        }
    }
}
