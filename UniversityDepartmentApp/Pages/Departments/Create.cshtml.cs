using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UniversityDepartmentApp.Data;
using UniversityDepartmentApp.Models;

namespace UniversityDepartmentApp.Pages.Departments
{
    public class CreateModel : PageModel
    {
        private readonly UniversityDepartmentApp.Data.UniContext _context;

        public CreateModel(UniversityDepartmentApp.Data.UniContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            // ViewData["UniversityId"] = new SelectList(_context.Universities, "Id", "Id");

            ViewData["UniversityList"] = new SelectList(_context.Universities, "Id", "UniversityName");
            return Page();

        }

        [BindProperty]
        public Department Department { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
           
            //var university = await _context.Universities.FindAsync(Department.UniversityId);
            //Department.University = university;

            _context.Departments.Add(Department);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
